using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingJsonDt
{
    public class GroupMaster : INotifyPropertyChanged
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string JsonDtAsString
        {
            get { return JsonDt.AsString; }
            set
            {
                JsonDt = new JsonDataTable(value);
                Dt.RowChanged += Dt_Changed;
                Dt.ColumnChanged += Dt_Changed;
                Dt.RowDeleted += Dt_Changed;
            }
        }

        public JsonDataTable JsonDt
        {
            get;
            set;
        }

        public DataTable Dt
        {
            get { return JsonDt.Dt; }
        }

        public bool IsUpdated
        {
            get { return JsonDt.IsUpdated; }
        }

        private void Dt_Changed(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsUpdated"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
