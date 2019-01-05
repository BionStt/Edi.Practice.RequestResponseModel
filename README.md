# Edi.Practice.RequestResponseModel
The Request and Response models used in my projects including my blog system.

[![Build status](https://dev.azure.com/ediwang/EdiWang-GitHub-Builds/_apis/build/status/Edi.Practice.RequestResponseModel-CI)](https://dev.azure.com/ediwang/EdiWang-GitHub-Builds/_build/latest?definitionId=37)

**Package Manager**
```
Install-Package Edi.Practice.RequestResponseModel
```

**.NET Core CLI**
```
dotnet add package Edi.Practice.RequestResponseModel
```

## Introduction

The request/response models are for designing multi layer applications or Web API services. This solves the problem where plain types are not good enough for describing related infomation such as if an API call is sucess or it's just an empty result from database.

For example, your are writing a method that query a database and return a Cat object:

```
public Cat GetCat(int id);
```

But when the caller get a null from GetCat(128), they don't know if there is no cat with id 128 in database, or is the service itself having exception. Futhermore, in common practices, a service usually returns a flag that indicats if the API call is success or not, along with the actual item. So the above method usually become like this:

```
public Response<Cat> GetCat(int id);
```

And the caller can check Response.IsSuccess to determine if anything went wrong with the API call, and get extra information about the response code, exception details etc..
