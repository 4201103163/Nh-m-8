using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class QUYDINH
    {
        long _qd1_1, _qd1_2, _qd2_1, _qd2_2;
        bool _qd4;
        public long Qd2_2
        {
            get { return _qd2_2; }
            set { _qd2_2 = value; }
        }

        public long Qd2_1
        {
            get { return _qd2_1; }
            set { _qd2_1 = value; }
        }

        public long Qd1_2
        {
            get { return _qd1_2; }
            set { _qd1_2 = value; }
        }

        public long Qd1_1
        {
            get { return _qd1_1; }
            set { _qd1_1 = value; }
        }

        public bool Qd4
        {
            get { return _qd4; }
            set { _qd4 = value; }
        }

        public QUYDINH(long qd11, long qd12, long qd21, long qd22, bool qd4)
        {
            Qd1_1 = qd11;
            Qd1_2 = qd12;
            Qd2_1 = qd21;
            Qd2_2 = qd22;
            Qd4 = qd4;
        }

        DB_QUYDINH db = new DB_QUYDINH();
        public void Sua()
        {
            string sql = "update QUYDINH set QD1_1 = @qd11, QD1_2 = @qd12, QD2_1 = @qd21, QD2_2 = @qd22, QD_4 = @qd4";
            db.Update_THAMSO(sql, new QUYDINH(Qd1_1, Qd1_2, Qd2_1, Qd2_2, Qd4));

        }
    }
}
