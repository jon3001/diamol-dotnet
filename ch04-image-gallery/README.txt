"Learn Docker in a Month of Lunches, Second Edition"

In Chapter 4 there is a small Golang application "Image Gallery".

This is a port from Golang to ASP.NET Razor pages. The main motivation 
is to compare the docker image sizes and runtime memory usage between the
Golang and .NET implementations.

For maximum optimization it seems to be recommended to use 'Chiseled'
base images and trimmmed/AOT compilations.
