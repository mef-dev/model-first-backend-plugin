using System;
using System.Collections.Generic;
using UCP.Common.Plugin;
using System.Linq;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    public class ModelFactory
    {
        public static BaseEntity CallSetViaWebModel(string entityName,
            string connectionString,
            BaseEntity webModel)
        {
            EntityBindContainer ebc = null;
            if (!EntityService.BindersDictionary.TryGetValue(entityName, out ebc))
                throw new Exception($"Entity with name {entityName} not found");

            var typeGen = typeof(CallSetModelCaller<,,,>);
            Type[] typeArgs = {ebc.Set_WebModel_Pair.Item1,
                ebc.Set_CallModel_Pair.Item1,
                ebc.Set_CallModel_Pair.Item2,
                ebc.Set_WebModel_Pair.Item2
            };
            var instanciator = typeGen.MakeGenericType(typeArgs);
            object o = Activator.CreateInstance(instanciator);

            /*
            var mi = typeGen.GetMethod("CallModel");
            MethodInfo miConstructed = mi.MakeGenericMethod(ebc.Set_WebModel_Pair.Item1, ebc.Set_WebModel_Pair.Item2);
            var r = miConstructed.Invoke(o, new object[] { connectionString });
            return (BaseEntity)mi.Invoke(o, new object[] { webModel });
            */


            /*
            var mi = instanciator.GetMethod("CallModel");
            MethodInfo miConstructed = mi.MakeGenericMethod(
                ebc.Set_WebModel_Pair.Item1, 
                ebc.Set_WebModel_Pair.Item2);
            */
            //return miConstructed.Invoke(o, new object[] { webModel }) as BaseEntity;
            

            
            var mi = instanciator.GetMethod("CallSetViaWebModel");
            var res = mi.Invoke(o, new object[] { connectionString, webModel});
            return res as BaseEntity;

            /*
            return (d) =>
            {
                ///return (BaseEntity)miConstructed.Invoke(o, new object[] { d });
                return (BaseEntity)miConstructed.Invoke(o, new object[] { d });
            };
            */
        }

        public static IEnumerable<BaseEntity> CallGetViaWebModel(string entityName,
            string connectionString,
            BaseEntity webModel)
        {
            return CallGetViaWebModel(entityName, connectionString, webModel, out BaseEntity outWebModel);
        }

        public static IEnumerable<BaseEntity> CallGetViaWebModel(string entityName,
            string connectionString,
            BaseEntity webModel,
            out BaseEntity webModelOutput)
        {
            EntityBindContainer ebc = null;
            if (!EntityService.BindersDictionary.TryGetValue(entityName, out ebc))
                throw new Exception($"Entity with name {entityName} not found");
            /*
            var typeGen = typeof(CallGetModelBinder<,,,,,>);
            Type[] typeArgs = {ebc.Get_WebModel_Pair.Item1,
                ebc.Get_CallModel_Pair.Item1,
                ebc.Get_CallModel_Pair.Item2,
                ebc.Get_WebModel_Pair.Item2,
                ebc.Get_ResultSet_Pair.Item1,
                ebc.Get_ResultSet_Pair.Item2
            };
            var instanciator = typeGen.MakeGenericType(typeArgs);
            */
            var instanciator = MakeConcreteGetBinderType(ebc);
            object o = Activator.CreateInstance(instanciator);

            var mi = instanciator.GetMethod("GetViaWebModel");

            webModelOutput = null;

            object[] parameters = new object[] { connectionString, webModel, webModelOutput };

            var res = mi.Invoke(o, parameters) as IEnumerable<BaseEntity>;

            webModelOutput = parameters[2] as BaseEntity;

            return res;
        }

        public static IEnumerable<object> CallGetViaCallModel(string entityName,
            string connectionString,
            object callModel,
            out object callModelOutput)
        {
            EntityBindContainer ebc = null;
            if (!EntityService.BindersDictionary.TryGetValue(entityName, out ebc))
                throw new Exception($"Entity with name {entityName} not found");
            /*
            var typeGen = typeof(CallGetModelBinder<,,,,,>);
            Type[] typeArgs = {ebc.Get_WebModel_Pair.Item1,
                ebc.Get_CallModel_Pair.Item1,
                ebc.Get_CallModel_Pair.Item2,
                ebc.Get_WebModel_Pair.Item2,
                ebc.Get_ResultSet_Pair.Item1,
                ebc.Get_ResultSet_Pair.Item2
            };
            var instanciator = typeGen.MakeGenericType(typeArgs);
            */
            var instanciator = MakeConcreteGetBinderType(ebc);
            object o = Activator.CreateInstance(instanciator);

            var mi = instanciator.GetMethod("GetViaCallModel");

            callModelOutput = null;

            object[] parameters = new object[] { connectionString, callModel, callModelOutput };

            var res1 = mi.Invoke(o, parameters);

            var res = res1 as IEnumerable<object>;

            callModelOutput = parameters[2];

            return res;
        }

        public static object CreateSetBinder(string entityOrProcedureName)
        {
            EntityBindContainer ebc = null;
            if (!EntityService.BindersDictionary.TryGetValue(entityOrProcedureName, out ebc))
            {
                ebc = EntityService.BindersDictionary.Values.FirstOrDefault(c => entityOrProcedureName.Equals(c.ProcedureName));
            }

            if (ebc == null)
                throw new Exception($"Binder for '{entityOrProcedureName}' not found");

            var instanciator = MakeConcreteSetBinderType(ebc);
            return Activator.CreateInstance(instanciator);
        }

        public static object CreateGetBinder(string entityOrProcedureName)
        {
            EntityBindContainer ebc = null;
            if (!EntityService.BindersDictionary.TryGetValue(entityOrProcedureName, out ebc))
            {
                ebc = EntityService.BindersDictionary.Values.FirstOrDefault(c => entityOrProcedureName.Equals(c.ProcedureName));
            }

            if (ebc == null)
                throw new Exception($"Binder for '{entityOrProcedureName}' not found");

            var instanciator = MakeConcreteGetBinderType(ebc);
            return Activator.CreateInstance(instanciator);
        }

        public static IActionCaller CreateActionCaller(CallProcedureBindContainer cpbc)
        {
            var typeGen = typeof(EntityActionCaller<,,,>);
            Type[] typeArgs = {cpbc.Set_WebModel_Request,
                cpbc.Set_CallModel_Request,
                cpbc.Set_CallModel_Response,
                cpbc.Set_WebModel_Response};
            var genType = typeGen.MakeGenericType(typeArgs);
            return Activator.CreateInstance(genType) as IActionCaller;
        }

        public static IViewCaller CreateViewCaller(CallGetProcedureBindContainer cgpbc)
        {
            var typeGen = typeof(ViewCaller<,,,,,>);
            Type[] typeArgs = {cgpbc.Set_WebModel_Request,
                cgpbc.Set_CallModel_Request,
                cgpbc.Set_CallModel_Response,
                cgpbc.Set_WebModel_Response,
                cgpbc.Get_CallModel_Output,
                cgpbc.Get_WebModel_Output};

            var genType = typeGen.MakeGenericType(typeArgs);
            return Activator.CreateInstance(genType) as IViewCaller;
        }

        private static Type MakeConcreteSetBinderType(EntityBindContainer ebc)
        {
            var typeGen = typeof(CallGetModelBinder<,,,,,>);
            Type[] typeArgs = {ebc.Get_WebModel_Pair.Item1,
                ebc.Get_CallModel_Pair.Item1,
                ebc.Get_CallModel_Pair.Item2,
                ebc.Get_WebModel_Pair.Item2,
                ebc.Get_ResultSet_Pair.Item1,
                ebc.Get_ResultSet_Pair.Item2
            };
            return typeGen.MakeGenericType(typeArgs);
        }

        private static Type MakeConcreteGetBinderType(EntityBindContainer ebc)
        {
            var typeGen = typeof(CallGetModelBinder<,,,,,>);
            Type[] typeArgs = {ebc.Get_WebModel_Pair.Item1,
                ebc.Get_CallModel_Pair.Item1,
                ebc.Get_CallModel_Pair.Item2,
                ebc.Get_WebModel_Pair.Item2,
                ebc.Get_ResultSet_Pair.Item1,
                ebc.Get_ResultSet_Pair.Item2
            };
            return typeGen.MakeGenericType(typeArgs);
        }
    }
}

