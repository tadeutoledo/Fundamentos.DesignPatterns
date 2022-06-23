using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fundamentos.DesignPatterns.Creational.FactoryMethod.Concret;

namespace Fundamentos.DesignPatterns.Creational.FactoryMethod.Abstract
{
  public abstract class DbFactory
  {
    public abstract DbConnector CreateConnector(string stringConnection);

    public static DbFactory Database(DataBase database)
    {
      switch (database)
      {
        case DataBase.SqlServer:
          return new SqlServerFactory();
        case DataBase.Oracle:
          return new OracleFactory();
        default:
          throw new ApplicationException("Database not found.");
      }
    }
  }
}