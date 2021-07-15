////////////////////////////////////////////////////////
// Прокси класс для списка родителей подчиненных 07/14/2021 16:26:05
// Сгенерирован из файла D:\Projects\Core\PluginPackage\models.xml
////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace Natec.Entities
{
    internal class EntitiesSubordinates
    {
        private static Dictionary<string, List<string>> relations = new Dictionary<string, List<string>>()
        {
};
/**********************************************************************************/
        public static List<string> Relations(string entity)
        {
            List<string> result = null;
            relations.TryGetValue(entity, out result);
            return result;
        }

        public static bool ValidRelation(string parent, string entity)
        {
            var relations = Relations(entity);
            if (relations != null)
            {
                return relations.Contains(parent);
            }
            else
                return false;
        }
    }
}