using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LazyLoadSample
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
