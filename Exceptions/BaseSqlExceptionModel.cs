﻿using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public class BaseSqlExceptionModel : BasePlatformExceptionModel
    {
        public int LevelMessage { get; set; }
        public int ErrNumber { get; set; }
        public int ErrNumberReason { get; set; }
        public long State { get; set; }
        public string HelpLink { get; set; }
        public string ResolveUrl { get; set; }
        public int? Number { get; set; }

        public BaseSqlExceptionModel Data { get; set; }

        public UCP.Common.Plugin.CommonPlatformException CreateCommonPlatformException(int? statusCode)
        {
            //var innerException = statusCode.HasValue ? Data?.CreateCommonPlatformException(null) : null;

            if (this.IsEmpty())
                return null;

            UCP.Common.Plugin.ServiceUnavailableException result = 
                new ServiceUnavailableException(this.Message, Data?.CreateCommonPlatformException(null))
                {
                    LevelMessage = this.LevelMessage,
                    ErrNumber = this.ErrNumber,
                    ErrNumberReason = this.ErrNumberReason,
                    State = this.State,
                    HelpLink = this.HelpLink,
                    HResult = this.ErrNumber,
                    Source = "PluginPackage.DB",
                    Number = this.Number,
                    IsCompleted = true
                };

                if (statusCode.HasValue)
                    result.StatusCode = statusCode.Value;

            return result;
        }

        private bool IsEmpty()
        {
            return this.Message == null &&
                this.ErrNumber == 0 &&
                this.ErrNumber == 0;
        }
    }
}