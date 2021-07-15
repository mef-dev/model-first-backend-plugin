using FluentSiren.Models;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Text;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
using UCP.Common.Plugin.Services;

namespace Natec.Entities
{
    [DocIgnore]
    internal sealed class StubPlugin : IBackendPlugin
    {
        public static IBackendPlugin StubInstance { get; private set; } = new StubPlugin();
        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public IPagedList<IModifiedTag, BaseEntity> Get(Filter filter, string view = null)
        {
            throw new NotImplementedException();
        }

        public JSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public Entity HateousSchema(BaseEntity baseEntity)
        {
            throw new NotImplementedException();
        }

        public BaseEntity Post(string lang, BaseEntity entity, string parent = null)
        {
            throw new NotImplementedException();
        }

        public BaseEntity PostEntityAction(string lang, BaseEntity entity, string action, string parent = null)
        {
            throw new NotImplementedException();
        }

        public BaseEntity Put(string id, string lang, BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public void SetApiContext(IApiContext context)
        {
            throw new NotImplementedException();
        }
    }
}
