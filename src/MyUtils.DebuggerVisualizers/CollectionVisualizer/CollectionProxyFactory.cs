using MyUtils.DebuggerVisualizers.CollectionVisualizer.Recources;
using MyUtils.DebuggerVisualizers.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtils.DebuggerVisualizers.CollectionVisualizer
{
    public class CollectionProxyFactory : IProxyObjectFactory
    {

        private static object[] emptyArray = new object[] { };
        public object CreateProxy(object target)
        {
            if (target is DataTable)
            {
                return (DataTable)target;
            }

            IEnumerable enumerableObject = (IEnumerable)target;

            var dt = new DataTable(target.GetType().GetCSharpType());

            Type type = target
                .GetType()
                .GetGenericArguments()
                .First();

            var props = type.GetProperties().Where(p => p.CanRead && !p.GetIndexParameters().Any()).ToArray();

            if (props.Any())
            {
                foreach (var prop in props)
                {
                    dt.Columns.Add(prop.Name);
                }

                foreach (var e in enumerableObject)
                {
                    var row = dt.NewRow();
                    foreach (DataColumn column in dt.Columns)
                    {
                        row[column] = type.GetProperty(column.ColumnName).GetValue(e, emptyArray);
                    }
                    dt.Rows.Add(row);
                }

            }
            else
            {
                dt.Columns.Add(Constants.ALTERNATE_PROPERTY_NAME);
                foreach (var e in enumerableObject)
                {
                    var row = dt.NewRow();
                    row[Constants.ALTERNATE_PROPERTY_NAME] = e.ToString();
                    dt.Rows.Add(row);
                }
            }


            return dt;
        }
    }
}
