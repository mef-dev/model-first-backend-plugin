using System;

namespace Bss.Entities
{
    public class CallProcedureBindContainer
    {
        public Type Set_CallModel_Request { get; set; }
        public Type Set_CallModel_Response { get; set; }
        public Type Set_WebModel_Request { get; set; }
        public Type Set_WebModel_Response { get; set; }
        public string ProcedureName { get; set; }

        public CallProcedureBindContainer( Type set_WebModel_Request,
            Type set_CallModel_Request,
            Type set_CallModel_Response,
            Type set_WebModel_Response)
        {
            Set_WebModel_Request = set_WebModel_Request;
            Set_CallModel_Request = set_CallModel_Request;
            Set_CallModel_Response = set_CallModel_Response;
            Set_WebModel_Response = set_WebModel_Response;
        }

        public CallProcedureBindContainer(
            string procedureName,
            Type set_WebModel_Request,
            Type set_CallModel_Request,
            Type set_CallModel_Response,
            Type set_WebModel_Response)
        {
            Set_WebModel_Request = set_WebModel_Request;
            Set_CallModel_Request = set_CallModel_Request;
            Set_CallModel_Response = set_CallModel_Response;
            Set_WebModel_Response = set_WebModel_Response;
            ProcedureName = procedureName;
        }
    }
}
