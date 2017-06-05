using MyUtils.DebuggerVisualizers.Internal;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyUtils.DebuggerVisualizers.KeyValueVisualizer
{
    public class KeyValueProxyFactory : IProxyObjectFactory
    {

        private static object[] emptyArray = new object[] { };
        public object CreateProxy(object target)
        {

            if (target == null)
            {
                return null;
            }


            DataTable table = new DataTable(target.GetType().GetCSharpType());
            table.Columns.Add("Key");
            table.Columns.Add("Value");

            if (target is NameValueCollection nvc)
            {
                foreach (string key in nvc.AllKeys)
                {
                    var row = table.NewRow();
                    row["Key"] = key;
                    row["Value"] = nvc[key];
                    table.Rows.Add(row);
                }
                table.AcceptChanges();
                return table;
            }

            if (target is IEnumerable enumerableObject)
            {
                Type itemType = null;
                PropertyInfo keyProp = null;
                PropertyInfo ValueProp = null;
                object[] emptyArray = new object[] { };
                foreach (var e in enumerableObject)
                {
                    if (itemType == null)
                    {
                        itemType = e.GetType();
                        keyProp = itemType.GetProperty("Key");
                        ValueProp = itemType.GetProperty("Value");
                    }

                    var row = table.NewRow();
                    row["Key"] = keyProp.GetValue(e, emptyArray);
                    row["Value"] = ValueProp.GetValue(e, emptyArray);
                    table.Rows.Add(row);
                }
                table.AcceptChanges();
                return table;
            }

            throw new NotSupportedException();
        }
    }
}
