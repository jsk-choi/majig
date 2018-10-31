# majig
Build things and configure it.

Supply your own connection string file, name it connStr.config, put it in root folder of majig.web and majig.db projects.

```connStr.config``` should look like this:

``` 
<connectionStrings>
  <add name="majigDb" connectionString="data source=[svr];initial catalog=majig;user id=[usr];password=[pwd];MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
</connectionStrings>
``` 
