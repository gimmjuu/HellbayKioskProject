namespace HellbayKioskProject {
    internal struct DataHolder {

        private int _id;
        private string _name;
        private int _price;
        private string _type;
        private int _count;

        public int DataId {
            get { return _id; }
            set { _id = value; }
        }

        public string DataName {
            get { return _name; }
            set { _name = value; }
        }

        public int DataPrice {
            get { return _price; }
            set { _price = value; }
        }

        public string DataCategory {
            get { return _type; }
            set { _type = value; }
        }

        public int DataCount {
            get { return _count; }
            set { _count = value; }
        }


    }
}
