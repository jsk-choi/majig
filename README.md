# majig
Build things and configure it.

Supply your own connection string file, name it connStr.config, put it in root folder of majig.web and majig.db projects.

```connStr.config``` should look like this:

``` 
<connectionStrings>
  <add name="DefaultConnection" connectionString="[your own conn str]" providerName="System.Data.SqlClient" />
  <add name="majigDb" connectionString="[your own conn str]" providerName="System.Data.SqlClient" />
</connectionStrings>
``` 
