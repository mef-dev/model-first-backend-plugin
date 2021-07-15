////////////////////////////////////////////////////////
// Прокси класс для связывания разных моделей с сущностями
////////////////////////////////////////////////////////

using System.Collections.Generic;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
//////////////////////////////////////////////////////////////////////////////
//                            Binders
//////////////////////////////////////////////////////////////////////////////
	[DocIgnore]
    public static class EntityBinders
    {
	}
//////////////////////////////////////////////////////////////////////////////
//                            DERIVED CLASSES
//////////////////////////////////////////////////////////////////////////////
#region [Derived classes]
#endregion
    [DocIgnore]
	public static class EntityService
	{
		private static Dictionary<string, EntityBindContainer> binders =
			new Dictionary<string, EntityBindContainer>()
			{
			};

		public static Dictionary<string, EntityBindContainer> BindersDictionary
		{
			get
			{
				return binders;
			}
		}
	}
}

