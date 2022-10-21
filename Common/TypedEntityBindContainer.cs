using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    public class TypedEntityBindContainer<TSet_CallModel_Request,
            TSet_CallModel_Response,
            TSet_WebModel_Request,
            TSet_WebModel_Response,
            TGet_CallModel_Request,
            TGet_CallModel_Response,
            TGet_WebModel_Request,
            TGet_WebModel_Response,
            TGet_CallModel_ResultSet,
            TGet_WebModel_ResultSet> : EntityBindContainer
        where TSet_CallModel_Request : class
        where TSet_CallModel_Response : class
        where TSet_WebModel_Request : class
        where TSet_WebModel_Response : class
        where TGet_CallModel_Request : class
        where TGet_CallModel_Response : class
        where TGet_WebModel_Request : class
        where TGet_WebModel_Response : class
        where TGet_CallModel_ResultSet : class
        where TGet_WebModel_ResultSet : class

    {
        #region [Property]
        public TSet_CallModel_Request Set_CallModel_Request { get; }
        public TSet_CallModel_Response Set_CallModel_Response { get; }
        public TSet_WebModel_Request Set_WebModel_Request { get; }
        public TSet_WebModel_Response Set_WebModel_Response { get; }
        public TGet_CallModel_Request Get_CallModel_Request { get; }
        public TGet_CallModel_Response Get_CallModel_Response { get; }
        public TGet_WebModel_Request Get_WebModel_Request { get; }
        public TGet_WebModel_Response Get_WebModel_Response { get; }
        public TGet_CallModel_ResultSet Get_CallModel_ResultSet { get; }
        public TGet_WebModel_ResultSet Get_WebModel_ResultSet { get; }

        #endregion

        public TypedEntityBindContainer(string entityName, string procedureName)
            : base(entityName, procedureName,
                 typeof(TSet_CallModel_Request),
                 typeof(TSet_CallModel_Response),
                 typeof(TSet_WebModel_Request),
                 typeof(TSet_WebModel_Response),
                 typeof(TGet_CallModel_Request),
                 typeof(TGet_CallModel_Response),
                 typeof(TGet_WebModel_Request),
                 typeof(TGet_WebModel_Response),
                 typeof(TGet_CallModel_ResultSet),
                 typeof(TGet_WebModel_ResultSet))
        { 

        }
    }
}
