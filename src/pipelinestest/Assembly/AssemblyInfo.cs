using Xunit;

[assembly: TestFramework("AutoTestExtras.Core.TestFramework", "AutoTestExtras.Core")]
[assembly: TestCaseOrderer("AutoTestExtras.Core.TestCaseOrderer", "AutoTestExtras.Core")]
[assembly: TestCollectionOrderer("AutoTestExtras.Core.CollectionOrderer", "AutoTestExtras.Core")]