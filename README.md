# dll-bundle
A test in how to bundle referenced assemblies into a single DLL

## BUNDLING MULTIPLE DLLs IN A VS PROJECT
Can't be done natively (?). There is a tool/NuGet Package called `ILMerge` that allows you to do it. Tried installing it and config using docs in github repo[^1], didn't quite nail it 😭. Applied a task tool[^2]: install the `ILMerge-Task` package, and it will take care of automatically merging everything together. Order can be customized with a `txt` file. 

Made two projects: a `dll-bundling` with the above, and a console application `dll-bundling-test` that reads the manually referenced bundled `dll` and invokes a method with dependencies in the attached libraries. 


[^1]: https://github.com/dotnet/ILMerge
[^2]: https://www.inogic.com/blog/2018/06/automate-ilmerge-for-workflowsplugins-to-merge-multiple-assemblies-into-one-in-dynamics-365/
