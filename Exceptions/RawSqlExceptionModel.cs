using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    /*
[ {"LevelMessage":17,"ErrNumber":50336,"Message":"������ ��������/��������� ���� ������","State":1,"HelpLink":null,"Xml":null,"
Data":"[ {\"LevelMessage\":17,\"ErrNumber\":50322,\"Message\":\"������ ����� ��� ������������. ������� ������ �����\",\"State\":1,\"HelpLink\":null,\"Xml\":null,\"Data\":null,\"ResolveUrl\":null}]","ResolveUrl":null}]     
     */
    [DocIgnore]
    public class RawSqlExceptionModel : BasePlatformExceptionModel
    {
        public string Test { get; set; } = "Test";
        public int LevelMessage { get; set; }
        public int ErrNumber { get; set; }
        public int ErrNumberReason { get; set; }
        //public string Message { get; set; }
        //public int State { get; set; }
        //public string Xml { get; set; }
        //public BaseSqlExceptionModel[] Data { get; set; }
        //[JsonConverter(converterType : typeof(ErrorDataJsonConverter))]
        //public object Data { get; set; }
        public RawSqlExceptionModel[] Data { get; set; }
        public RawSqlExceptionModel(BaseSqlExceptionModel baseSqlExceptionModel)
        {
            this.Message = baseSqlExceptionModel.Message;

            this.LevelMessage = baseSqlExceptionModel.LevelMessage;
            this.ErrNumber = baseSqlExceptionModel.ErrNumber;
            //this.Xml = baseSqlExceptionModel.Xml;
            this.ErrNumberReason = baseSqlExceptionModel.ErrNumberReason;
            if ((baseSqlExceptionModel.Data != null) && (!(baseSqlExceptionModel.Data is string)))
            {
                /*
                this.Data = ((BaseSqlExceptionModel[])baseSqlExceptionModel.Data)
                    .Select((bse) => new RawSqlExceptionModel(bse))
                    .ToArray();
                */
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
