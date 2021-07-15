using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public class RawSqlExceptionModel : BasePlatformExceptionModel
    {
        public string Test { get; set; } = "Test";
        public int LevelMessage { get; set; }
        public int ErrNumber { get; set; }
        public int ErrNumberReason { get; set; }
        public RawSqlExceptionModel[] Data { get; set; }
        public RawSqlExceptionModel(BaseSqlExceptionModel baseSqlExceptionModel)
        {
            this.Message = baseSqlExceptionModel.Message;
            this.LevelMessage = baseSqlExceptionModel.LevelMessage;
            this.ErrNumber = baseSqlExceptionModel.ErrNumber;
            this.ErrNumberReason = baseSqlExceptionModel.ErrNumberReason;
            if ((baseSqlExceptionModel.Data != null) && (!(baseSqlExceptionModel.Data is string)))
            {
            }
            else
            {
                this.Data = null;
            }
        }
    }
}