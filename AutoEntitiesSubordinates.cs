////////////////////////////////////////////////////////
// Прокси класс для списка родителей подчиненных 10/21/2022 12:54:28
// Сгенерирован из файла C:\Users\keiqsa\Projects\model-first-backend-plugin\models.xml
////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace Bss.Entities
{
    internal class EntitiesSubordinates
    {
        private static Dictionary<string, List<string>> relations = new Dictionary<string, List<string>>()
        {
              {
                "accounts", new List<string>()
                {
                      "customers"          
                }
              },
              {
                "accounts/customeraccounts", new List<string>()
                {
                      
                }
              },
              {
                "accounttaxes", new List<string>()
                {
                      "accounts"          
                }
              },
              {
                "addresses", new List<string>()
                {
                      "associations",
                       "customers",
                       "subscribers"          
                }
              },
              {
                "adjustments", new List<string>()
                {
                      "accounts"          
                }
              },
              {
                "agreements", new List<string>()
                {
                      "subscribers"          
                }
              },
              {
                "associations", new List<string>()
                {
                      "associations",
                       null          
                }
              },
              {
                "associations/details", new List<string>()
                {
                      
                }
              },
              {
                "authcodes", new List<string>()
                {
                      "customers",
                       "subscribers"          
                }
              },
              {
                "bankaccounts", new List<string>()
                {
                      
                }
              },
              {
                "bankdetails", new List<string>()
                {
                      "associations",
                       "customers"          
                }
              },
              {
                "bankstatements", new List<string>()
                {
                      null          
                }
              },
              {
                "bankstatementtransactions", new List<string>()
                {
                      
                }
              },
              {
                "billingtasks", new List<string>()
                {
                      "accounts"          
                }
              },
              {
                "callcredits", new List<string>()
                {
                      "subscribers"          
                }
              },
              {
                "callusergroups", new List<string>()
                {
                      null          
                }
              },
              {
                "contracts", new List<string>()
                {
                      "associations",
                       "customers",
                       "subscribers"          
                }
              },
              {
                "customerpayments", new List<string>()
                {
                      "accounts",
                       "paymentdocuments"          
                }
              },
              {
                "customerpayments/allocatedpayments", new List<string>()
                {
                      
                }
              },
              {
                "customers", new List<string>()
                {
                      "associations",
                       null          
                }
              },
              {
                "customers/customerextentions", new List<string>()
                {
                      
                }
              },
              {
                "customers/details", new List<string>()
                {
                      
                }
              },
              {
                "customertypes", new List<string>()
                {
                      
                }
              },
              {
                "discounts", new List<string>()
                {
                      "customers"          
                }
              },
              {
                "environment", new List<string>()
                {
                      
                }
              },
              {
                "extentions", new List<string>()
                {
                      "subscribers"          
                }
              },
              {
                "gains", new List<string>()
                {
                      "customers"          
                }
              },
              {
                "memberships", new List<string>()
                {
                      "subscribers"          
                }
              },
              {
                "networks", new List<string>()
                {
                      
                }
              },
              {
                "paymentdocuments", new List<string>()
                {
                      "accounts"          
                }
              },
              {
                "paymentregistry", new List<string>()
                {
                      "bankaccounts"          
                }
              },
              {
                "phonenumbers", new List<string>()
                {
                      "callusergroups"          
                }
              },
              {
                "portabilitynumbers", new List<string>()
                {
                      null          
                }
              },
              {
                "profiles", new List<string>()
                {
                      "associations",
                       "customers",
                       "subscribers"          
                }
              },
              {
                "ratingdata", new List<string>()
                {
                      null          
                }
              },
              {
                "servicesubscriptions", new List<string>()
                {
                      "templatesubscriptions"          
                }
              },
              {
                "subscribers", new List<string>()
                {
                      "customers"          
                }
              },
              {
                "subscribers/details", new List<string>()
                {
                      
                }
              },
              {
                "tasks", new List<string>()
                {
                      
                }
              },
              {
                "templatesubscriptions", new List<string>()
                {
                      "agreements"          
                }
              },
              {
                "treenodehistory", new List<string>()
                {
                      
                }
              },
              {
                "treenodeproperties", new List<string>()
                {
                      "associations",
                       "customers",
                       "subscribers"          
                }
              }};
/**********************************************************************************/
        public static List<string> Relations(string entity)
        {
            List<string> result = null;
            relations.TryGetValue(entity?.ToLower(), out result);
            return result;
        }

        public static bool ValidRelation(string parent, string entity)
        {
            var relations = Relations(entity);
            if (relations != null)
            {
                return relations.Contains(parent?.ToLower());
            }
            else
                return false;
        }
    }
}