// Description: Evaluate C# code and expression in T-SQL stored procedure, function and trigger.
// Website & Documentation: https://github.com/zzzprojects/Eval-SQL.NET
// Forum & Issues: https://github.com/zzzprojects/Eval-SQL.NET/issues
// License: https://github.com/zzzprojects/Eval-SQL.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System.Collections;
using System.Data;
using Microsoft.SqlServer.Server;

namespace Z.Expressions.SqlServer.Eval
{
    public partial struct SQLNET
    {
        [SqlFunction(DataAccess = DataAccessKind.Read, FillRowMethodName = "Fill_SQLNET_EvalTVF_1", TableDefinition = "Value_1 sql_variant")]
        public static IEnumerable SQLNET_EvalTVF_1(SQLNET sqlnet)
        {
            var obj = sqlnet.Eval();
            return DataTableHelper.GetDataRows(obj);
        }

        public static void Fill_SQLNET_EvalTVF_1(object obj, out object value1)
        {
            var row = (DataRow) obj;
            value1 = row[0];
        }
    }
}