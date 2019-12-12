# FunctionApp-JsonResult-Error
Illustrates error when returning JsonResult in a .NET Core 3.1 azure function v3 application

#### Problem:
Returning JsonResult from an azure function with .NET Core 3.1 runtime throws an unhandled exception at the host level.


#### Exceptions thrown based on scenario:
<ol>
<li>Vanilla AF: System.Private.CoreLib: Exception while executing function: FunctionTestJsonOutput. FunctionAppJsonError: Method not found: 'Void Microsoft.AspNetCore.Mvc.JsonResult..ctor(System.Object, Newtonsoft.Json.JsonSerializerSettings)'.</li>
<li>After adding Nuget Microsoft.AspNetCore.Mvc.NewtonsoftJson: Microsoft.AspNetCore.Mvc.NewtonsoftJson: Property 'JsonResult.SerializerSettings' must be an instance of type 'Newtonsoft.Json.JsonSerializerSettings'.</li>
<li>After using DI with IFunctionsHostBuilder.Services.AddControllers().AddNewtonsoftJson(): Microsoft.AspNetCore.Authentication.Core: No authentication handlers are registered. Did you forget to call AddAuthentication().Add[SomeAuthHandler]("WebJobsAuthLevel",...)?.</li>
</ol>

#### Workaround:
None

#### Discussion:
TBD

#### Solution:
TBD
