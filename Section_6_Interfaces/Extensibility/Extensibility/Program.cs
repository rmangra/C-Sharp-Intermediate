﻿namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\temp\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
