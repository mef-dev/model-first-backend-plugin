using System;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public class CallGetProcedureBindContainer : CallProcedureBindContainer
    {
        public Type Get_CallModel_Output;
        public Type Get_WebModel_Output;

        public CallGetProcedureBindContainer(Type get_WebModel_Request,
            Type get_CallModel_Request,
            Type get_CallModel_Response,
            Type get_WebModel_Response,
            Type get_CallModel_Output,
            Type get_WebModel_Output):base(get_WebModel_Request, get_CallModel_Request, get_CallModel_Response, get_WebModel_Response)
        {
            Get_CallModel_Output = get_CallModel_Output;
            Get_WebModel_Output = get_WebModel_Output;
        }
    }
}