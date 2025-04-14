"Learn Docker in a Month of Lunches, Second Edition"

In Chapter 4 there is a small Golang application "Image Gallery".

This is a port from Golang to ASP.NET Razor pages. The main motivation 
is to compare the docker image sizes and runtime memory usage between the
Golang and .NET implementations.

For maximum optimization it seems to be recommended to use 'Chiseled'
base images and trimmmed/AOT compilations.


Resources:
https://medium.com/@codebob75/creating-and-consuming-apis-in-net-c-d24f9c414b96
https://andrewlock.net/exploring-the-dotnet-8-preview-updates-to-docker-images-in-dotnet-8/
https://learn.microsoft.com/en-gb/visualstudio/containers/container-build?view=vs-2022