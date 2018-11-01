# majig
Build things and configure it.

Supply your own connection string file, name it connStr.config, put it in root folder of majig.web and majig.db projects.

```connStr.config``` should look like this:

``` 
<connectionStrings>
  <add name="majigDb" connectionString="data source=[svr];initial catalog=majig;user id=[usr];password=[pwd];MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
</connectionStrings>
``` 

Using SQL Server:

1. Run majig.web db migrations (PM > update-database)
2. Launch majig.web (to seed admin user)
3. Execute majig.sql - 03 esk8r_schema.sql
4. Execute majig.sql - 04 esk8r_data.sql
