<a name='assembly'></a>
# Essentials

## Contents

- [CryptoFunctions](#T-Essentials-Functions-CryptoFunctions 'Essentials.Functions.CryptoFunctions')
  - [HashString(input,algorithm,encoding)](#M-Essentials-Functions-CryptoFunctions-HashString-System-String,System-Security-Cryptography-HashAlgorithm,System-Text-Encoding- 'Essentials.Functions.CryptoFunctions.HashString(System.String,System.Security.Cryptography.HashAlgorithm,System.Text.Encoding)')
- [ExpressionFunctions](#T-Essentials-Functions-ExpressionFunctions 'Essentials.Functions.ExpressionFunctions')
  - [BuildExpressionForProperty\`\`1(propertyName)](#M-Essentials-Functions-ExpressionFunctions-BuildExpressionForProperty``1-System-String- 'Essentials.Functions.ExpressionFunctions.BuildExpressionForProperty``1(System.String)')
  - [CombineByAndAlsoCondition\`\`1(left,right)](#M-Essentials-Functions-ExpressionFunctions-CombineByAndAlsoCondition``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- 'Essentials.Functions.ExpressionFunctions.CombineByAndAlsoCondition``1(System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})')
  - [CombineByOrElseCondition\`\`1(left,right)](#M-Essentials-Functions-ExpressionFunctions-CombineByOrElseCondition``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- 'Essentials.Functions.ExpressionFunctions.CombineByOrElseCondition``1(System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})')
- [ExpressionParameterReplacer](#T-Essentials-Functions-ExpressionParameterReplacer 'Essentials.Functions.ExpressionParameterReplacer')
  - [#ctor(fromParameters,toParameters)](#M-Essentials-Functions-ExpressionParameterReplacer-#ctor-System-Collections-Generic-IList{System-Linq-Expressions-ParameterExpression},System-Collections-Generic-IList{System-Linq-Expressions-ParameterExpression}- 'Essentials.Functions.ExpressionParameterReplacer.#ctor(System.Collections.Generic.IList{System.Linq.Expressions.ParameterExpression},System.Collections.Generic.IList{System.Linq.Expressions.ParameterExpression})')
  - [VisitParameter()](#M-Essentials-Functions-ExpressionParameterReplacer-VisitParameter-System-Linq-Expressions-ParameterExpression- 'Essentials.Functions.ExpressionParameterReplacer.VisitParameter(System.Linq.Expressions.ParameterExpression)')
- [FieldInfoExtensions](#T-Essentials-Extensions-FieldInfoExtensions 'Essentials.Extensions.FieldInfoExtensions')
  - [GetAttribute\`\`1(fieldInfo,inherit)](#M-Essentials-Extensions-FieldInfoExtensions-GetAttribute``1-System-Reflection-FieldInfo,System-Boolean- 'Essentials.Extensions.FieldInfoExtensions.GetAttribute``1(System.Reflection.FieldInfo,System.Boolean)')
  - [HasAttribute\`\`1(fieldInfo,inherit)](#M-Essentials-Extensions-FieldInfoExtensions-HasAttribute``1-System-Reflection-FieldInfo,System-Boolean- 'Essentials.Extensions.FieldInfoExtensions.HasAttribute``1(System.Reflection.FieldInfo,System.Boolean)')
- [HttpContextExtensions](#T-Essentials-Extensions-HttpContextExtensions 'Essentials.Extensions.HttpContextExtensions')
  - [GetAbsoluteRoute(httpContext,relativeUrl)](#M-Essentials-Extensions-HttpContextExtensions-GetAbsoluteRoute-Microsoft-AspNetCore-Http-HttpContext,System-String- 'Essentials.Extensions.HttpContextExtensions.GetAbsoluteRoute(Microsoft.AspNetCore.Http.HttpContext,System.String)')
  - [GetRouteValueOrDefault(httpContext,routeValueKey)](#M-Essentials-Extensions-HttpContextExtensions-GetRouteValueOrDefault-Microsoft-AspNetCore-Http-HttpContext,System-String- 'Essentials.Extensions.HttpContextExtensions.GetRouteValueOrDefault(Microsoft.AspNetCore.Http.HttpContext,System.String)')
  - [IsMobileDevice(httpContext)](#M-Essentials-Extensions-HttpContextExtensions-IsMobileDevice-Microsoft-AspNetCore-Http-HttpContext- 'Essentials.Extensions.HttpContextExtensions.IsMobileDevice(Microsoft.AspNetCore.Http.HttpContext)')
  - [IsUserAuthenticated(httpContext)](#M-Essentials-Extensions-HttpContextExtensions-IsUserAuthenticated-Microsoft-AspNetCore-Http-HttpContext- 'Essentials.Extensions.HttpContextExtensions.IsUserAuthenticated(Microsoft.AspNetCore.Http.HttpContext)')
- [InfoResult](#T-Essentials-Results-InfoResult 'Essentials.Results.InfoResult')
  - [Message](#P-Essentials-Results-InfoResult-Message 'Essentials.Results.InfoResult.Message')
  - [ResultFrom(message)](#M-Essentials-Results-InfoResult-ResultFrom-System-String- 'Essentials.Results.InfoResult.ResultFrom(System.String)')
- [KeyValuePairsResult\`2](#T-Essentials-Results-KeyValuePairsResult`2 'Essentials.Results.KeyValuePairsResult`2')
  - [Pairs](#P-Essentials-Results-KeyValuePairsResult`2-Pairs 'Essentials.Results.KeyValuePairsResult`2.Pairs')
  - [ResultFrom(dictionary)](#M-Essentials-Results-KeyValuePairsResult`2-ResultFrom-System-Collections-Generic-IDictionary{`0,`1}- 'Essentials.Results.KeyValuePairsResult`2.ResultFrom(System.Collections.Generic.IDictionary{`0,`1})')
- [MethodInfoExtensions](#T-Essentials-Extensions-MethodInfoExtensions 'Essentials.Extensions.MethodInfoExtensions')
  - [GetAttribute\`\`1(methodInfo,inherit)](#M-Essentials-Extensions-MethodInfoExtensions-GetAttribute``1-System-Reflection-MethodInfo,System-Boolean- 'Essentials.Extensions.MethodInfoExtensions.GetAttribute``1(System.Reflection.MethodInfo,System.Boolean)')
  - [HasAttribute\`\`1(methodInfo,inherit)](#M-Essentials-Extensions-MethodInfoExtensions-HasAttribute``1-System-Reflection-MethodInfo,System-Boolean- 'Essentials.Extensions.MethodInfoExtensions.HasAttribute``1(System.Reflection.MethodInfo,System.Boolean)')
- [MutationResult](#T-Essentials-Results-MutationResult 'Essentials.Results.MutationResult')
  - [Message](#P-Essentials-Results-MutationResult-Message 'Essentials.Results.MutationResult.Message')
  - [MutatedEntityId](#P-Essentials-Results-MutationResult-MutatedEntityId 'Essentials.Results.MutationResult.MutatedEntityId')
  - [Succeeded](#P-Essentials-Results-MutationResult-Succeeded 'Essentials.Results.MutationResult.Succeeded')
  - [ResultFrom(mutatedEntityId,message)](#M-Essentials-Results-MutationResult-ResultFrom-System-Object,System-String- 'Essentials.Results.MutationResult.ResultFrom(System.Object,System.String)')
- [PaginatedItemsResult\`1](#T-Essentials-Results-PaginatedItemsResult`1 'Essentials.Results.PaginatedItemsResult`1')
  - [Count](#P-Essentials-Results-PaginatedItemsResult`1-Count 'Essentials.Results.PaginatedItemsResult`1.Count')
  - [CurrentPage](#P-Essentials-Results-PaginatedItemsResult`1-CurrentPage 'Essentials.Results.PaginatedItemsResult`1.CurrentPage')
  - [Items](#P-Essentials-Results-PaginatedItemsResult`1-Items 'Essentials.Results.PaginatedItemsResult`1.Items')
  - [PageSize](#P-Essentials-Results-PaginatedItemsResult`1-PageSize 'Essentials.Results.PaginatedItemsResult`1.PageSize')
  - [PagesCount](#P-Essentials-Results-PaginatedItemsResult`1-PagesCount 'Essentials.Results.PaginatedItemsResult`1.PagesCount')
  - [StartRow](#P-Essentials-Results-PaginatedItemsResult`1-StartRow 'Essentials.Results.PaginatedItemsResult`1.StartRow')
  - [TotalCount](#P-Essentials-Results-PaginatedItemsResult`1-TotalCount 'Essentials.Results.PaginatedItemsResult`1.TotalCount')
  - [ResultFrom(items,pageSize,currentPage,totalCount)](#M-Essentials-Results-PaginatedItemsResult`1-ResultFrom-System-Collections-Generic-IEnumerable{`0},System-Int32,System-Int32,System-Int32- 'Essentials.Results.PaginatedItemsResult`1.ResultFrom(System.Collections.Generic.IEnumerable{`0},System.Int32,System.Int32,System.Int32)')
- [PropertyInfoExtensions](#T-Essentials-Extensions-PropertyInfoExtensions 'Essentials.Extensions.PropertyInfoExtensions')
  - [GetAttribute\`\`1(propertyInfo)](#M-Essentials-Extensions-PropertyInfoExtensions-GetAttribute``1-System-Reflection-PropertyInfo- 'Essentials.Extensions.PropertyInfoExtensions.GetAttribute``1(System.Reflection.PropertyInfo)')
  - [HasAttribute\`\`1(propertyInfo)](#M-Essentials-Extensions-PropertyInfoExtensions-HasAttribute``1-System-Reflection-PropertyInfo- 'Essentials.Extensions.PropertyInfoExtensions.HasAttribute``1(System.Reflection.PropertyInfo)')
- [RandomFunctions](#T-Essentials-Functions-RandomFunctions 'Essentials.Functions.RandomFunctions')
  - [GetRandomElementFromArray\`\`1(array)](#M-Essentials-Functions-RandomFunctions-GetRandomElementFromArray``1-``0[]- 'Essentials.Functions.RandomFunctions.GetRandomElementFromArray``1(``0[])')
  - [GetRandomString(size,usedChars)](#M-Essentials-Functions-RandomFunctions-GetRandomString-System-Int32,System-String- 'Essentials.Functions.RandomFunctions.GetRandomString(System.Int32,System.String)')
- [ReflectionFunctions](#T-Essentials-Functions-ReflectionFunctions 'Essentials.Functions.ReflectionFunctions')
  - [GetCorrectPropertyMember\`\`1(expression)](#M-Essentials-Functions-ReflectionFunctions-GetCorrectPropertyMember``1-System-Linq-Expressions-Expression{System-Func{``0,System-Object}}- 'Essentials.Functions.ReflectionFunctions.GetCorrectPropertyMember``1(System.Linq.Expressions.Expression{System.Func{``0,System.Object}})')
  - [GetCorrectPropertyMember\`\`2(expression)](#M-Essentials-Functions-ReflectionFunctions-GetCorrectPropertyMember``2-System-Linq-Expressions-Expression{System-Func{``0,``1}}- 'Essentials.Functions.ReflectionFunctions.GetCorrectPropertyMember``2(System.Linq.Expressions.Expression{System.Func{``0,``1}})')
- [StandardResult](#T-Essentials-Results-StandardResult 'Essentials.Results.StandardResult')
  - [Message](#P-Essentials-Results-StandardResult-Message 'Essentials.Results.StandardResult.Message')
  - [Succeeded](#P-Essentials-Results-StandardResult-Succeeded 'Essentials.Results.StandardResult.Succeeded')
  - [ResultFrom(succeeded,message)](#M-Essentials-Results-StandardResult-ResultFrom-System-Boolean,System-String- 'Essentials.Results.StandardResult.ResultFrom(System.Boolean,System.String)')
  - [SuccessfulResult(message)](#M-Essentials-Results-StandardResult-SuccessfulResult-System-String- 'Essentials.Results.StandardResult.SuccessfulResult(System.String)')
  - [UnsuccessfulResult(message)](#M-Essentials-Results-StandardResult-UnsuccessfulResult-System-String- 'Essentials.Results.StandardResult.UnsuccessfulResult(System.String)')
- [StatusResult\`1](#T-Essentials-Results-StatusResult`1 'Essentials.Results.StatusResult`1')
  - [Message](#P-Essentials-Results-StatusResult`1-Message 'Essentials.Results.StatusResult`1.Message')
  - [Status](#P-Essentials-Results-StatusResult`1-Status 'Essentials.Results.StatusResult`1.Status')
  - [ResultFrom(status,message)](#M-Essentials-Results-StatusResult`1-ResultFrom-`0,System-String- 'Essentials.Results.StatusResult`1.ResultFrom(`0,System.String)')
- [StringExtensions](#T-Essentials-Extensions-StringExtensions 'Essentials.Extensions.StringExtensions')
  - [ToFirstLower(stringValue)](#M-Essentials-Extensions-StringExtensions-ToFirstLower-System-String- 'Essentials.Extensions.StringExtensions.ToFirstLower(System.String)')
  - [ToFirstUpper(stringValue)](#M-Essentials-Extensions-StringExtensions-ToFirstUpper-System-String- 'Essentials.Extensions.StringExtensions.ToFirstUpper(System.String)')
  - [ToPluralString(stringValue)](#M-Essentials-Extensions-StringExtensions-ToPluralString-System-String- 'Essentials.Extensions.StringExtensions.ToPluralString(System.String)')
  - [ToSingularString(stringValue)](#M-Essentials-Extensions-StringExtensions-ToSingularString-System-String- 'Essentials.Extensions.StringExtensions.ToSingularString(System.String)')
- [StringFunctions](#T-Essentials-Functions-StringFunctions 'Essentials.Functions.StringFunctions')
  - [ClearMultipleIntervals(value)](#M-Essentials-Functions-StringFunctions-ClearMultipleIntervals-System-String- 'Essentials.Functions.StringFunctions.ClearMultipleIntervals(System.String)')
  - [ConvertToKey(stringValue)](#M-Essentials-Functions-StringFunctions-ConvertToKey-System-String- 'Essentials.Functions.StringFunctions.ConvertToKey(System.String)')
  - [Slugify(value)](#M-Essentials-Functions-StringFunctions-Slugify-System-String- 'Essentials.Functions.StringFunctions.Slugify(System.String)')
  - [SplitStringByCapitalLetters(stringValue)](#M-Essentials-Functions-StringFunctions-SplitStringByCapitalLetters-System-String- 'Essentials.Functions.StringFunctions.SplitStringByCapitalLetters(System.String)')
  - [StripTags(source)](#M-Essentials-Functions-StringFunctions-StripTags-System-String- 'Essentials.Functions.StringFunctions.StripTags(System.String)')
- [TypeExtensions](#T-Essentials-Extensions-TypeExtensions 'Essentials.Extensions.TypeExtensions')
  - [GetAttribute\`\`1(type,inherit)](#M-Essentials-Extensions-TypeExtensions-GetAttribute``1-System-Type,System-Boolean- 'Essentials.Extensions.TypeExtensions.GetAttribute``1(System.Type,System.Boolean)')
  - [GetDefaultValue(type)](#M-Essentials-Extensions-TypeExtensions-GetDefaultValue-System-Type- 'Essentials.Extensions.TypeExtensions.GetDefaultValue(System.Type)')
  - [GetGenericInterface(type,genericInterface)](#M-Essentials-Extensions-TypeExtensions-GetGenericInterface-System-Type,System-Type- 'Essentials.Extensions.TypeExtensions.GetGenericInterface(System.Type,System.Type)')
  - [GetTypeByIgnoreTheNullable(type)](#M-Essentials-Extensions-TypeExtensions-GetTypeByIgnoreTheNullable-System-Type- 'Essentials.Extensions.TypeExtensions.GetTypeByIgnoreTheNullable(System.Type)')
  - [HasAttribute\`\`1(type,inherit)](#M-Essentials-Extensions-TypeExtensions-HasAttribute``1-System-Type,System-Boolean- 'Essentials.Extensions.TypeExtensions.HasAttribute``1(System.Type,System.Boolean)')
  - [HasInterface(type,interfaceType)](#M-Essentials-Extensions-TypeExtensions-HasInterface-System-Type,System-Type- 'Essentials.Extensions.TypeExtensions.HasInterface(System.Type,System.Type)')
  - [HasInterface\`\`1(type)](#M-Essentials-Extensions-TypeExtensions-HasInterface``1-System-Type- 'Essentials.Extensions.TypeExtensions.HasInterface``1(System.Type)')
  - [ImplementsGenericInterface(type,interfaceType)](#M-Essentials-Extensions-TypeExtensions-ImplementsGenericInterface-System-Type,System-Type- 'Essentials.Extensions.TypeExtensions.ImplementsGenericInterface(System.Type,System.Type)')
  - [IsCollectionType(type)](#M-Essentials-Extensions-TypeExtensions-IsCollectionType-System-Type- 'Essentials.Extensions.TypeExtensions.IsCollectionType(System.Type)')
  - [IsEnumerableType(type)](#M-Essentials-Extensions-TypeExtensions-IsEnumerableType-System-Type- 'Essentials.Extensions.TypeExtensions.IsEnumerableType(System.Type)')
  - [IsGenericType(type,genericType)](#M-Essentials-Extensions-TypeExtensions-IsGenericType-System-Type,System-Type- 'Essentials.Extensions.TypeExtensions.IsGenericType(System.Type,System.Type)')
  - [IsIterableType(type)](#M-Essentials-Extensions-TypeExtensions-IsIterableType-System-Type- 'Essentials.Extensions.TypeExtensions.IsIterableType(System.Type)')
  - [IsListType(type)](#M-Essentials-Extensions-TypeExtensions-IsListType-System-Type- 'Essentials.Extensions.TypeExtensions.IsListType(System.Type)')
- [TypeFunctions](#T-Essentials-Functions-TypeFunctions 'Essentials.Functions.TypeFunctions')
  - [GetClassesTypesThatImplementsAnInterface(interfaceType,assemblies)](#M-Essentials-Functions-TypeFunctions-GetClassesTypesThatImplementsAnInterface-System-Type,System-Collections-Generic-IEnumerable{System-Reflection-Assembly}- 'Essentials.Functions.TypeFunctions.GetClassesTypesThatImplementsAnInterface(System.Type,System.Collections.Generic.IEnumerable{System.Reflection.Assembly})')
  - [GetClassesTypesThatImplements\`\`1(assemblies)](#M-Essentials-Functions-TypeFunctions-GetClassesTypesThatImplements``1-System-Collections-Generic-IEnumerable{System-Reflection-Assembly}- 'Essentials.Functions.TypeFunctions.GetClassesTypesThatImplements``1(System.Collections.Generic.IEnumerable{System.Reflection.Assembly})')
- [ValueObject](#T-Essentials-Abstractions-ValueObject 'Essentials.Abstractions.ValueObject')
  - [EqualOperator(left,right)](#M-Essentials-Abstractions-ValueObject-EqualOperator-Essentials-Abstractions-ValueObject,Essentials-Abstractions-ValueObject- 'Essentials.Abstractions.ValueObject.EqualOperator(Essentials.Abstractions.ValueObject,Essentials.Abstractions.ValueObject)')
  - [Equals()](#M-Essentials-Abstractions-ValueObject-Equals-System-Object- 'Essentials.Abstractions.ValueObject.Equals(System.Object)')
  - [GetEqualityComponents()](#M-Essentials-Abstractions-ValueObject-GetEqualityComponents 'Essentials.Abstractions.ValueObject.GetEqualityComponents')
  - [GetHashCode()](#M-Essentials-Abstractions-ValueObject-GetHashCode 'Essentials.Abstractions.ValueObject.GetHashCode')
  - [NotEqualOperator(left,right)](#M-Essentials-Abstractions-ValueObject-NotEqualOperator-Essentials-Abstractions-ValueObject,Essentials-Abstractions-ValueObject- 'Essentials.Abstractions.ValueObject.NotEqualOperator(Essentials.Abstractions.ValueObject,Essentials.Abstractions.ValueObject)')
- [ValueResult\`1](#T-Essentials-Results-ValueResult`1 'Essentials.Results.ValueResult`1')
  - [Value](#P-Essentials-Results-ValueResult`1-Value 'Essentials.Results.ValueResult`1.Value')
  - [ResultFrom(value)](#M-Essentials-Results-ValueResult`1-ResultFrom-`0- 'Essentials.Results.ValueResult`1.ResultFrom(`0)')

<a name='T-Essentials-Functions-CryptoFunctions'></a>
## CryptoFunctions `type`

##### Namespace

Essentials.Functions

##### Summary

Essentials cryptography functions.

<a name='M-Essentials-Functions-CryptoFunctions-HashString-System-String,System-Security-Cryptography-HashAlgorithm,System-Text-Encoding-'></a>
### HashString(input,algorithm,encoding) `method`

##### Summary

Generate MD5 hash from string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| algorithm | [System.Security.Cryptography.HashAlgorithm](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.HashAlgorithm 'System.Security.Cryptography.HashAlgorithm') |  |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') |  |

<a name='T-Essentials-Functions-ExpressionFunctions'></a>
## ExpressionFunctions `type`

##### Namespace

Essentials.Functions

##### Summary

Essentials expression functions.

<a name='M-Essentials-Functions-ExpressionFunctions-BuildExpressionForProperty``1-System-String-'></a>
### BuildExpressionForProperty\`\`1(propertyName) `method`

##### Summary

Build lambda expression from entity type and property name.
Example BuildExpressionForProperty{Entity}("Id") represents (Entity x) => x.Id.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='M-Essentials-Functions-ExpressionFunctions-CombineByAndAlsoCondition``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>
### CombineByAndAlsoCondition\`\`1(left,right) `method`

##### Summary

Creates an expressions with AND conditional operation.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') |  |
| right | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the entity for expression. |

<a name='M-Essentials-Functions-ExpressionFunctions-CombineByOrElseCondition``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>
### CombineByOrElseCondition\`\`1(left,right) `method`

##### Summary

Creates an expressions with OR conditional operation.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') |  |
| right | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the entity for expression. |

<a name='T-Essentials-Functions-ExpressionParameterReplacer'></a>
## ExpressionParameterReplacer `type`

##### Namespace

Essentials.Functions

##### Summary

Implementation of replacer for expression parameter.

<a name='M-Essentials-Functions-ExpressionParameterReplacer-#ctor-System-Collections-Generic-IList{System-Linq-Expressions-ParameterExpression},System-Collections-Generic-IList{System-Linq-Expressions-ParameterExpression}-'></a>
### #ctor(fromParameters,toParameters) `constructor`

##### Summary

Initializes a new instance of the [ExpressionParameterReplacer](#T-Essentials-Functions-ExpressionParameterReplacer 'Essentials.Functions.ExpressionParameterReplacer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fromParameters | [System.Collections.Generic.IList{System.Linq.Expressions.ParameterExpression}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Linq.Expressions.ParameterExpression}') |  |
| toParameters | [System.Collections.Generic.IList{System.Linq.Expressions.ParameterExpression}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Linq.Expressions.ParameterExpression}') |  |

<a name='M-Essentials-Functions-ExpressionParameterReplacer-VisitParameter-System-Linq-Expressions-ParameterExpression-'></a>
### VisitParameter() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Essentials-Extensions-FieldInfoExtensions'></a>
## FieldInfoExtensions `type`

##### Namespace

Essentials.Extensions

##### Summary

Extensions for [FieldInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.FieldInfo 'System.Reflection.FieldInfo').

<a name='M-Essentials-Extensions-FieldInfoExtensions-GetAttribute``1-System-Reflection-FieldInfo,System-Boolean-'></a>
### GetAttribute\`\`1(fieldInfo,inherit) `method`

##### Summary

Gets the specified attribute from field info.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldInfo | [System.Reflection.FieldInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.FieldInfo 'System.Reflection.FieldInfo') |  |
| inherit | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Attribute type. |

<a name='M-Essentials-Extensions-FieldInfoExtensions-HasAttribute``1-System-Reflection-FieldInfo,System-Boolean-'></a>
### HasAttribute\`\`1(fieldInfo,inherit) `method`

##### Summary

Check whether field info has the specified attribute.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldInfo | [System.Reflection.FieldInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.FieldInfo 'System.Reflection.FieldInfo') |  |
| inherit | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Attribute type. |

<a name='T-Essentials-Extensions-HttpContextExtensions'></a>
## HttpContextExtensions `type`

##### Namespace

Essentials.Extensions

##### Summary

Extensions for [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext').

<a name='M-Essentials-Extensions-HttpContextExtensions-GetAbsoluteRoute-Microsoft-AspNetCore-Http-HttpContext,System-String-'></a>
### GetAbsoluteRoute(httpContext,relativeUrl) `method`

##### Summary

Gets the absolute URL from relative URL of the current request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Extensions-HttpContextExtensions-GetRouteValueOrDefault-Microsoft-AspNetCore-Http-HttpContext,System-String-'></a>
### GetRouteValueOrDefault(httpContext,routeValueKey) `method`

##### Summary

Gets route value by its key.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |
| routeValueKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Extensions-HttpContextExtensions-IsMobileDevice-Microsoft-AspNetCore-Http-HttpContext-'></a>
### IsMobileDevice(httpContext) `method`

##### Summary

Returns boolean that represents whether the request is made from mobile device or not.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |

<a name='M-Essentials-Extensions-HttpContextExtensions-IsUserAuthenticated-Microsoft-AspNetCore-Http-HttpContext-'></a>
### IsUserAuthenticated(httpContext) `method`

##### Summary

Returns boolean that represents whether current user is authenticated or not.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |

<a name='T-Essentials-Results-InfoResult'></a>
## InfoResult `type`

##### Namespace

Essentials.Results

##### Summary

Result type that is designed to provides information only.

<a name='P-Essentials-Results-InfoResult-Message'></a>
### Message `property`

##### Summary

Result message.

<a name='M-Essentials-Results-InfoResult-ResultFrom-System-String-'></a>
### ResultFrom(message) `method`

##### Summary

Returns info result from general input.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Essentials-Results-KeyValuePairsResult`2'></a>
## KeyValuePairsResult\`2 `type`

##### Namespace

Essentials.Results

##### Summary

Result that contains collection of pairs represented by a key and a value.
Result is object representation of dictionary.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Type of the key. |
| TValue | Type of the value. |

<a name='P-Essentials-Results-KeyValuePairsResult`2-Pairs'></a>
### Pairs `property`

##### Summary

Collection of all items in the result.

<a name='M-Essentials-Results-KeyValuePairsResult`2-ResultFrom-System-Collections-Generic-IDictionary{`0,`1}-'></a>
### ResultFrom(dictionary) `method`

##### Summary

Returns key value items result from general input.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dictionary | [System.Collections.Generic.IDictionary{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{`0,`1}') |  |

<a name='T-Essentials-Extensions-MethodInfoExtensions'></a>
## MethodInfoExtensions `type`

##### Namespace

Essentials.Extensions

##### Summary

Extensions for [MethodInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.MethodInfo 'System.Reflection.MethodInfo').

<a name='M-Essentials-Extensions-MethodInfoExtensions-GetAttribute``1-System-Reflection-MethodInfo,System-Boolean-'></a>
### GetAttribute\`\`1(methodInfo,inherit) `method`

##### Summary

Gets the specified attribute from method info.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodInfo | [System.Reflection.MethodInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.MethodInfo 'System.Reflection.MethodInfo') |  |
| inherit | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Attribute type. |

<a name='M-Essentials-Extensions-MethodInfoExtensions-HasAttribute``1-System-Reflection-MethodInfo,System-Boolean-'></a>
### HasAttribute\`\`1(methodInfo,inherit) `method`

##### Summary

Check whether method info has the specified attribute.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodInfo | [System.Reflection.MethodInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.MethodInfo 'System.Reflection.MethodInfo') |  |
| inherit | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Attribute type. |

<a name='T-Essentials-Results-MutationResult'></a>
## MutationResult `type`

##### Namespace

Essentials.Results

##### Summary

Result type that provides the identifier entity that participate in mutation operation and message.

<a name='P-Essentials-Results-MutationResult-Message'></a>
### Message `property`

##### Summary

Result message.

<a name='P-Essentials-Results-MutationResult-MutatedEntityId'></a>
### MutatedEntityId `property`

##### Summary

Id of the mutated entity.

<a name='P-Essentials-Results-MutationResult-Succeeded'></a>
### Succeeded `property`

##### Summary

Flat that indicates whether the result is successful or not.

<a name='M-Essentials-Results-MutationResult-ResultFrom-System-Object,System-String-'></a>
### ResultFrom(mutatedEntityId,message) `method`

##### Summary

Returns mutation result from general input.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mutatedEntityId | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Essentials-Results-PaginatedItemsResult`1'></a>
## PaginatedItemsResult\`1 `type`

##### Namespace

Essentials.Results

##### Summary

Result that contains collection of items and corresponding pagination details.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | List item type. |

<a name='P-Essentials-Results-PaginatedItemsResult`1-Count'></a>
### Count `property`

##### Summary

Count of the items in the current page.

<a name='P-Essentials-Results-PaginatedItemsResult`1-CurrentPage'></a>
### CurrentPage `property`

##### Summary

Current page index.

<a name='P-Essentials-Results-PaginatedItemsResult`1-Items'></a>
### Items `property`

##### Summary

Collection of all items in the result.

<a name='P-Essentials-Results-PaginatedItemsResult`1-PageSize'></a>
### PageSize `property`

##### Summary

Amount items on a page.

<a name='P-Essentials-Results-PaginatedItemsResult`1-PagesCount'></a>
### PagesCount `property`

##### Summary

Amount of the pages based on all items and page size.

<a name='P-Essentials-Results-PaginatedItemsResult`1-StartRow'></a>
### StartRow `property`

##### Summary

Index of the first item of the current page based on all items.

<a name='P-Essentials-Results-PaginatedItemsResult`1-TotalCount'></a>
### TotalCount `property`

##### Summary

Count of all items in all pages.

<a name='M-Essentials-Results-PaginatedItemsResult`1-ResultFrom-System-Collections-Generic-IEnumerable{`0},System-Int32,System-Int32,System-Int32-'></a>
### ResultFrom(items,pageSize,currentPage,totalCount) `method`

##### Summary

Returns paginated items result from general input.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') |  |
| pageSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| currentPage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| totalCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Essentials-Extensions-PropertyInfoExtensions'></a>
## PropertyInfoExtensions `type`

##### Namespace

Essentials.Extensions

##### Summary

Extensions for [PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo').

<a name='M-Essentials-Extensions-PropertyInfoExtensions-GetAttribute``1-System-Reflection-PropertyInfo-'></a>
### GetAttribute\`\`1(propertyInfo) `method`

##### Summary

Gets the specified attribute from property info.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyInfo | [System.Reflection.PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Attribute type. |

<a name='M-Essentials-Extensions-PropertyInfoExtensions-HasAttribute``1-System-Reflection-PropertyInfo-'></a>
### HasAttribute\`\`1(propertyInfo) `method`

##### Summary

Check whether property info has the specified attribute.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyInfo | [System.Reflection.PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Attribute type. |

<a name='T-Essentials-Functions-RandomFunctions'></a>
## RandomFunctions `type`

##### Namespace

Essentials.Functions

##### Summary

Essentials random generation functions.

<a name='M-Essentials-Functions-RandomFunctions-GetRandomElementFromArray``1-``0[]-'></a>
### GetRandomElementFromArray\`\`1(array) `method`

##### Summary

Gets a random element from array.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the array elements. |

<a name='M-Essentials-Functions-RandomFunctions-GetRandomString-System-Int32,System-String-'></a>
### GetRandomString(size,usedChars) `method`

##### Summary

Gets a random string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| size | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| usedChars | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Essentials-Functions-ReflectionFunctions'></a>
## ReflectionFunctions `type`

##### Namespace

Essentials.Functions

##### Summary

Essential reflection functions.

<a name='M-Essentials-Functions-ReflectionFunctions-GetCorrectPropertyMember``1-System-Linq-Expressions-Expression{System-Func{``0,System-Object}}-'></a>
### GetCorrectPropertyMember\`\`1(expression) `method`

##### Summary

Gets property member info.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Object}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Object}}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TProperty | Type of the object. |

<a name='M-Essentials-Functions-ReflectionFunctions-GetCorrectPropertyMember``2-System-Linq-Expressions-Expression{System-Func{``0,``1}}-'></a>
### GetCorrectPropertyMember\`\`2(expression) `method`

##### Summary

Gets property member info.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,``1}}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TProperty | Type of the object. |
| TResult | Type of the property. |

<a name='T-Essentials-Results-StandardResult'></a>
## StandardResult `type`

##### Namespace

Essentials.Results

##### Summary

Result type that provides boolean status and message.

<a name='P-Essentials-Results-StandardResult-Message'></a>
### Message `property`

##### Summary

Result message.

<a name='P-Essentials-Results-StandardResult-Succeeded'></a>
### Succeeded `property`

##### Summary

Flat that indicates whether the result is successful or not.

<a name='M-Essentials-Results-StandardResult-ResultFrom-System-Boolean,System-String-'></a>
### ResultFrom(succeeded,message) `method`

##### Summary

Returns standard result from general input.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| succeeded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Results-StandardResult-SuccessfulResult-System-String-'></a>
### SuccessfulResult(message) `method`

##### Summary

Returns successful standard result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Results-StandardResult-UnsuccessfulResult-System-String-'></a>
### UnsuccessfulResult(message) `method`

##### Summary

Returns unsuccessful standard result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Essentials-Results-StatusResult`1'></a>
## StatusResult\`1 `type`

##### Namespace

Essentials.Results

##### Summary

Result type that provides generic status and message.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStatus | Type of the status. |

<a name='P-Essentials-Results-StatusResult`1-Message'></a>
### Message `property`

##### Summary

Result message.

<a name='P-Essentials-Results-StatusResult`1-Status'></a>
### Status `property`

##### Summary

Result status.

<a name='M-Essentials-Results-StatusResult`1-ResultFrom-`0,System-String-'></a>
### ResultFrom(status,message) `method`

##### Summary

Returns status result from general input.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| status | [\`0](#T-`0 '`0') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Essentials-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

Essentials.Extensions

##### Summary

Extensions for [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

<a name='M-Essentials-Extensions-StringExtensions-ToFirstLower-System-String-'></a>
### ToFirstLower(stringValue) `method`

##### Summary

Transforms the first char of string in lowercase.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Extensions-StringExtensions-ToFirstUpper-System-String-'></a>
### ToFirstUpper(stringValue) `method`

##### Summary

Transforms the first char of string in uppercase.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Extensions-StringExtensions-ToPluralString-System-String-'></a>
### ToPluralString(stringValue) `method`

##### Summary

Gets plural form of string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Extensions-StringExtensions-ToSingularString-System-String-'></a>
### ToSingularString(stringValue) `method`

##### Summary

Gets singular form of a string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Essentials-Functions-StringFunctions'></a>
## StringFunctions `type`

##### Namespace

Essentials.Functions

##### Summary

Essential string functions.

<a name='M-Essentials-Functions-StringFunctions-ClearMultipleIntervals-System-String-'></a>
### ClearMultipleIntervals(value) `method`

##### Summary

Trim useless intervals from a string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Functions-StringFunctions-ConvertToKey-System-String-'></a>
### ConvertToKey(stringValue) `method`

##### Summary

Convert pascal case word into a key format word (upper and snake case).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Functions-StringFunctions-Slugify-System-String-'></a>
### Slugify(value) `method`

##### Summary

Build slug from the specified string.
Inspired by https://github.com/simov/slugify .

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Functions-StringFunctions-SplitStringByCapitalLetters-System-String-'></a>
### SplitStringByCapitalLetters(stringValue) `method`

##### Summary

Splits pascal case string to separate words.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Essentials-Functions-StringFunctions-StripTags-System-String-'></a>
### StripTags(source) `method`

##### Summary

Strip HTML and XML tags via regex replacement.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Essentials-Extensions-TypeExtensions'></a>
## TypeExtensions `type`

##### Namespace

Essentials.Extensions

##### Summary

Extensions for [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type').

<a name='M-Essentials-Extensions-TypeExtensions-GetAttribute``1-System-Type,System-Boolean-'></a>
### GetAttribute\`\`1(type,inherit) `method`

##### Summary

Gets the specified attribute or default from type.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| inherit | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Attribute type. |

<a name='M-Essentials-Extensions-TypeExtensions-GetDefaultValue-System-Type-'></a>
### GetDefaultValue(type) `method`

##### Summary

Returns the default value of type.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Essentials-Extensions-TypeExtensions-GetGenericInterface-System-Type,System-Type-'></a>
### GetGenericInterface(type,genericInterface) `method`

##### Summary

Get generic interface of a type.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| genericInterface | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Essentials-Extensions-TypeExtensions-GetTypeByIgnoreTheNullable-System-Type-'></a>
### GetTypeByIgnoreTheNullable(type) `method`

##### Summary

Gets type by ignoring the nullable type.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Essentials-Extensions-TypeExtensions-HasAttribute``1-System-Type,System-Boolean-'></a>
### HasAttribute\`\`1(type,inherit) `method`

##### Summary

Check whether the type has the specified attribute.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| inherit | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Attribute type. |

<a name='M-Essentials-Extensions-TypeExtensions-HasInterface-System-Type,System-Type-'></a>
### HasInterface(type,interfaceType) `method`

##### Summary

Check whether the type implement the specified interface.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| interfaceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Essentials-Extensions-TypeExtensions-HasInterface``1-System-Type-'></a>
### HasInterface\`\`1(type) `method`

##### Summary

Check whether the type implement the specified interface.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of interface. |

<a name='M-Essentials-Extensions-TypeExtensions-ImplementsGenericInterface-System-Type,System-Type-'></a>
### ImplementsGenericInterface(type,interfaceType) `method`

##### Summary

Check whether a type is implement a generic interface.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| interfaceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Essentials-Extensions-TypeExtensions-IsCollectionType-System-Type-'></a>
### IsCollectionType(type) `method`

##### Summary

Checks whether a type is a collection or not.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Essentials-Extensions-TypeExtensions-IsEnumerableType-System-Type-'></a>
### IsEnumerableType(type) `method`

##### Summary

Checks whether a type is enumerable.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Essentials-Extensions-TypeExtensions-IsGenericType-System-Type,System-Type-'></a>
### IsGenericType(type,genericType) `method`

##### Summary

Checks whether a type is a generic type.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| genericType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Essentials-Extensions-TypeExtensions-IsIterableType-System-Type-'></a>
### IsIterableType(type) `method`

##### Summary

Checks whether a type is a iterable type.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Essentials-Extensions-TypeExtensions-IsListType-System-Type-'></a>
### IsListType(type) `method`

##### Summary

Checks whether a type is a list or not.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='T-Essentials-Functions-TypeFunctions'></a>
## TypeFunctions `type`

##### Namespace

Essentials.Functions

##### Summary

Essential type functions.

<a name='M-Essentials-Functions-TypeFunctions-GetClassesTypesThatImplementsAnInterface-System-Type,System-Collections-Generic-IEnumerable{System-Reflection-Assembly}-'></a>
### GetClassesTypesThatImplementsAnInterface(interfaceType,assemblies) `method`

##### Summary

Returns a collection of all types that implements the specified interface from collection of assemblies.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interfaceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| assemblies | [System.Collections.Generic.IEnumerable{System.Reflection.Assembly}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Reflection.Assembly}') |  |

<a name='M-Essentials-Functions-TypeFunctions-GetClassesTypesThatImplements``1-System-Collections-Generic-IEnumerable{System-Reflection-Assembly}-'></a>
### GetClassesTypesThatImplements\`\`1(assemblies) `method`

##### Summary

Returns a collection of all types that implements the specified interface from collection of assemblies.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assemblies | [System.Collections.Generic.IEnumerable{System.Reflection.Assembly}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Reflection.Assembly}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInterface | Type of the interface. |

<a name='T-Essentials-Abstractions-ValueObject'></a>
## ValueObject `type`

##### Namespace

Essentials.Abstractions

##### Summary

Abstract implementation of value object.

<a name='M-Essentials-Abstractions-ValueObject-EqualOperator-Essentials-Abstractions-ValueObject,Essentials-Abstractions-ValueObject-'></a>
### EqualOperator(left,right) `method`

##### Summary

Compares and confirms the equality of specified value objects.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Essentials.Abstractions.ValueObject](#T-Essentials-Abstractions-ValueObject 'Essentials.Abstractions.ValueObject') |  |
| right | [Essentials.Abstractions.ValueObject](#T-Essentials-Abstractions-ValueObject 'Essentials.Abstractions.ValueObject') |  |

<a name='M-Essentials-Abstractions-ValueObject-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Essentials-Abstractions-ValueObject-GetEqualityComponents'></a>
### GetEqualityComponents() `method`

##### Summary

Gets equality components.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Essentials-Abstractions-ValueObject-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Essentials-Abstractions-ValueObject-NotEqualOperator-Essentials-Abstractions-ValueObject,Essentials-Abstractions-ValueObject-'></a>
### NotEqualOperator(left,right) `method`

##### Summary

Inverse the equality check of [Equals](#M-Essentials-Abstractions-ValueObject-Equals-System-Object- 'Essentials.Abstractions.ValueObject.Equals(System.Object)').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Essentials.Abstractions.ValueObject](#T-Essentials-Abstractions-ValueObject 'Essentials.Abstractions.ValueObject') |  |
| right | [Essentials.Abstractions.ValueObject](#T-Essentials-Abstractions-ValueObject 'Essentials.Abstractions.ValueObject') |  |

<a name='T-Essentials-Results-ValueResult`1'></a>
## ValueResult\`1 `type`

##### Namespace

Essentials.Results

##### Summary

Result type that is designed to provides value in the form of object.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | Type of the value. |

<a name='P-Essentials-Results-ValueResult`1-Value'></a>
### Value `property`

##### Summary

Result value.

<a name='M-Essentials-Results-ValueResult`1-ResultFrom-`0-'></a>
### ResultFrom(value) `method`

##### Summary

Returns value result from general input.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') |  |
