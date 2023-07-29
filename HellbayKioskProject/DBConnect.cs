using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace HellbayKioskProject {
    internal class DBConnect {
        // 자주 쓰는 공통 객체
        public string connectionString = string.Format(
            "Host={0}; Database={1}; Username={2}; Password={3};",
            "127.0.0.1", "hellbay", "postgres", "1234");

        /// <summary>
        /// 메뉴 DB 조회
        /// </summary>
        /// <returns> <[메뉴 아이디, 이름, 가격], [], ...> </returns>
        public List<DataHolder> GetMenuInfo() {
            // struct로 수정
            var dataList = new List<DataHolder>();
            string sql = "SELECT * FROM \"TB_MENU\" ORDER BY \"MENU_ID\"";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);  // 하나의 명령만 실행
                    using (NpgsqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            // 구조체 생성 후 리스트에 추가
                            var data = new DataHolder {
                                DataId = Convert.ToInt32(reader["MENU_ID"]),
                                DataName = reader["MENU_NAME"].ToString(),
                                DataPrice = Convert.ToInt32(reader["MENU_PRICE"]),
                                DataCategory = reader["MENU_CATEGORY"].ToString()
                            };
                            dataList.Add(data);
                        }
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            return dataList;
        }

        // 마지막 주문 id 반환
        public int GetOrderId() {
            var ret = new int();
            string sql = $"SELECT \"ORD_ID\" FROM \"TB_ORDER\" ORDER BY \"ORD_ID\" DESC LIMIT 1";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);   // 실행
                    using (NpgsqlDataReader reader = cmd.ExecuteReader()) {
                        reader.Read();
                        ret = Convert.ToInt32(reader["ORD_ID"]);
                        Console.WriteLine("order_id : ", ret);
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            return ret;
        }

        public bool InsertRow(DataHolder aData, string aTable) {
            //var currentTime = DateTime.Now;
            var currentTime = DateTime.UtcNow;


            string sql = $"INSERT INTO \"TB_{aTable}\"";
            // 주문 시간, 주문 총액, 결제 방식
            if (aTable == "ORDER") {
                // 주문 건 Data 추가 
                sql += $" (\"ORD_DATETIME\", \"ORD_TOTAL_PRICE\", \"ORD_PAYMENT\") VALUES (@currentTime, {aData.DataPrice}, '{aData.DataCategory}')";
            }
            else if (aTable == "ORDER_ITEM") {
                // 주문 메뉴 Data 추가
                var ord_id = GetOrderId();
                sql += $" (\"ORD_ID\", \"MENU_ID\", \"ITEM_COUNT\") VALUES ({ord_id}, {aData.DataId}, {aData.DataCount})";
            }

            // 쿼리문 확인!
            Console.WriteLine(sql);

            var ret = false;

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    if (aTable == "ORDER") {
                        cmd.Parameters.AddWithValue("@currentTime", currentTime);
                    }
                    cmd.ExecuteNonQuery();
                    ret = true;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }

            return ret;

        }

        // date 조회하기
        public List<string> GetOrderDate() {
            List<string> ret = new List<string>();
            string sql = "SELECT DISTINCT CONCAT(EXTRACT('YEAR' FROM \"ORD_DATETIME\"), '년 ', EXTRACT('MONTH' FROM \"ORD_DATETIME\"), '월') AS DATE FROM public.\"TB_ORDER\" ORDER BY DATE";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            Console.WriteLine(reader["DATE"]);
                            ret.Add(reader["DATE"].ToString());
                        }
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            return ret;
        }

        public DataTable GetOrderData() {
            DataTable dt = new DataTable();
            dt.Columns.Add("OrderId", typeof(Int32));
            dt.Columns.Add("OrderDate", typeof(DateTime));
            dt.Columns.Add("OrderPrice", typeof(Int32));
            dt.Columns.Add("PayType");

            string sql = "SELECT * FROM \"TB_ORDER\";";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            dt.Rows.Add(reader["ORD_ID"], reader["ORD_DATETIME"], reader["ORD_TOTAL_PRICE"], reader["ORD_PAYMENT"]);
                        }
                    }
                }
                catch (Exception e) { Console.WriteLine(e); }
            }
            return dt;
        }
    }
}