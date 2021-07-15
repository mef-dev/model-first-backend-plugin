using System;
using System.Collections.Generic;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public class EntityBindContainer
    {
        public string EntityName { get; set; }
        public string ProcedureName { get; set; }
        public Tuple<Type, Type> Set_CallModel_Pair { get; set; }
        public Tuple<Type, Type> Set_WebModel_Pair { get; set; }
        public Tuple<Type, Type> Get_CallModel_Pair { get; set; }
        public Tuple<Type, Type> Get_WebModel_Pair { get; set; }
        public Tuple<Type, Type> Get_ResultSet_Pair { get; set; }

        public CallProcedureBindContainer SetBindContainer { get; set; }
        public IDictionary<string, CallGetProcedureBindContainer> GetViewBindContainers { get; set; }
        public IDictionary<string, CallProcedureBindContainer> ActionBindContainers { get; set; }

        public EntityBindContainer(string entityName)
        {
            EntityName = entityName;
        }
        public EntityBindContainer(
            string entityName,
            string procedureName,
            Type Set_CallModel_Request,
            Type Set_CallModel_Response,
            Type Set_WebModel_Request,
            Type Set_WebModel_Response,
            Type Get_CallModel_Request,
            Type Get_CallModel_Response,
            Type Get_WebModel_Request,
            Type Get_WebModel_Response,
            Type Get_CallModel_ResultSet,
            Type Get_WebModel_ResultSet)
        {
            EntityName = entityName;
            ProcedureName = procedureName;

            SetBindContainer = new CallProcedureBindContainer(Set_WebModel_Request,
                Set_CallModel_Request,
                Set_CallModel_Response,
                Set_WebModel_Response);

            Set_CallModel_Pair = new Tuple<Type, Type>(Set_CallModel_Request, Set_CallModel_Response);
            Set_WebModel_Pair = new Tuple<Type, Type>(Set_WebModel_Request, Set_WebModel_Response);
            Get_CallModel_Pair = new Tuple<Type, Type>(Get_CallModel_Request, Get_CallModel_Response);
            Get_WebModel_Pair = new Tuple<Type, Type>(Get_WebModel_Request, Get_WebModel_Response);
            Get_ResultSet_Pair = new Tuple<Type, Type>(Get_CallModel_ResultSet, Get_WebModel_ResultSet);
        }
    }
}