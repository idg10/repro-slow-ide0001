# Slow IDE0001 execution

This project demonstrates a problem that the https://github.com/reaqtive/reaqtor project encountered in which the IDE0001 analyzer takes an extremely long time to run on certain files. (It was taking long enough that our automated builds were timing out when trying to run `dotnet format`.)

This project has no dependencies. It copies what we think is the minimum of elements from Reaqtor to cause the problem to occur.
