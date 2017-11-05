using System.Data;
using Newtonsoft.Json;
using System.ComponentModel;

namespace TestingJsonDt
{
    public class JsonDataTable : INotifyPropertyChanged
    {
        private string dbString;
        public readonly DataTable Dt;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsUpdated
        {
            get { return this.dbString != this.AsString; }
        }

        public string AsString
        {
            get { return JsonConvert.SerializeObject(Dt); }
        }

        public JsonDataTable(string json)
        {
            this.Dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            this.dbString = this.AsString;
        }
    }
}
