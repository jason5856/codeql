// This file contains auto-generated code.
// Generated from `System.Linq.Expressions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`.
namespace System
{
    namespace Dynamic
    {
        public abstract class BinaryOperationBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            protected BinaryOperationBinder(System.Linq.Expressions.ExpressionType operation) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackBinaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject arg) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackBinaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject arg, System.Dynamic.DynamicMetaObject errorSuggestion);
            public System.Linq.Expressions.ExpressionType Operation { get => throw null; }
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public abstract class BindingRestrictions
        {
            public static System.Dynamic.BindingRestrictions Combine(System.Collections.Generic.IList<System.Dynamic.DynamicMetaObject> contributingObjects) => throw null;
            public static System.Dynamic.BindingRestrictions Empty;
            public static System.Dynamic.BindingRestrictions GetExpressionRestriction(System.Linq.Expressions.Expression expression) => throw null;
            public static System.Dynamic.BindingRestrictions GetInstanceRestriction(System.Linq.Expressions.Expression expression, object instance) => throw null;
            public static System.Dynamic.BindingRestrictions GetTypeRestriction(System.Linq.Expressions.Expression expression, System.Type type) => throw null;
            public System.Dynamic.BindingRestrictions Merge(System.Dynamic.BindingRestrictions restrictions) => throw null;
            public System.Linq.Expressions.Expression ToExpression() => throw null;
        }
        public sealed class CallInfo
        {
            public int ArgumentCount { get => throw null; }
            public System.Collections.ObjectModel.ReadOnlyCollection<string> ArgumentNames { get => throw null; }
            public CallInfo(int argCount, System.Collections.Generic.IEnumerable<string> argNames) => throw null;
            public CallInfo(int argCount, params string[] argNames) => throw null;
            public override bool Equals(object obj) => throw null;
            public override int GetHashCode() => throw null;
        }
        public abstract class ConvertBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            protected ConvertBinder(System.Type type, bool @explicit) => throw null;
            public bool Explicit { get => throw null; }
            public System.Dynamic.DynamicMetaObject FallbackConvert(System.Dynamic.DynamicMetaObject target) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackConvert(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
            public override sealed System.Type ReturnType { get => throw null; }
            public System.Type Type { get => throw null; }
        }
        public abstract class CreateInstanceBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public System.Dynamic.CallInfo CallInfo { get => throw null; }
            protected CreateInstanceBinder(System.Dynamic.CallInfo callInfo) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackCreateInstance(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackCreateInstance(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion);
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public abstract class DeleteIndexBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public System.Dynamic.CallInfo CallInfo { get => throw null; }
            protected DeleteIndexBinder(System.Dynamic.CallInfo callInfo) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackDeleteIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackDeleteIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject errorSuggestion);
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public abstract class DeleteMemberBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            protected DeleteMemberBinder(string name, bool ignoreCase) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackDeleteMember(System.Dynamic.DynamicMetaObject target) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackDeleteMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
            public bool IgnoreCase { get => throw null; }
            public string Name { get => throw null; }
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public class DynamicMetaObject
        {
            public virtual System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value) => throw null;
            public virtual System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder) => throw null;
            public static System.Dynamic.DynamicMetaObject Create(object value, System.Linq.Expressions.Expression expression) => throw null;
            public DynamicMetaObject(System.Linq.Expressions.Expression expression, System.Dynamic.BindingRestrictions restrictions) => throw null;
            public DynamicMetaObject(System.Linq.Expressions.Expression expression, System.Dynamic.BindingRestrictions restrictions, object value) => throw null;
            public static System.Dynamic.DynamicMetaObject[] EmptyMetaObjects;
            public System.Linq.Expressions.Expression Expression { get => throw null; }
            public virtual System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames() => throw null;
            public bool HasValue { get => throw null; }
            public System.Type LimitType { get => throw null; }
            public System.Dynamic.BindingRestrictions Restrictions { get => throw null; }
            public System.Type RuntimeType { get => throw null; }
            public object Value { get => throw null; }
        }
        public abstract class DynamicMetaObjectBinder : System.Runtime.CompilerServices.CallSiteBinder
        {
            public abstract System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args);
            public override sealed System.Linq.Expressions.Expression Bind(object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Linq.Expressions.LabelTarget returnLabel) => throw null;
            protected DynamicMetaObjectBinder() => throw null;
            public System.Dynamic.DynamicMetaObject Defer(System.Dynamic.DynamicMetaObject target, params System.Dynamic.DynamicMetaObject[] args) => throw null;
            public System.Dynamic.DynamicMetaObject Defer(params System.Dynamic.DynamicMetaObject[] args) => throw null;
            public System.Linq.Expressions.Expression GetUpdateExpression(System.Type type) => throw null;
            public virtual System.Type ReturnType { get => throw null; }
        }
        public class DynamicObject : System.Dynamic.IDynamicMetaObjectProvider
        {
            protected DynamicObject() => throw null;
            public virtual System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames() => throw null;
            public virtual System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) => throw null;
            public virtual bool TryBinaryOperation(System.Dynamic.BinaryOperationBinder binder, object arg, out object result) => throw null;
            public virtual bool TryConvert(System.Dynamic.ConvertBinder binder, out object result) => throw null;
            public virtual bool TryCreateInstance(System.Dynamic.CreateInstanceBinder binder, object[] args, out object result) => throw null;
            public virtual bool TryDeleteIndex(System.Dynamic.DeleteIndexBinder binder, object[] indexes) => throw null;
            public virtual bool TryDeleteMember(System.Dynamic.DeleteMemberBinder binder) => throw null;
            public virtual bool TryGetIndex(System.Dynamic.GetIndexBinder binder, object[] indexes, out object result) => throw null;
            public virtual bool TryGetMember(System.Dynamic.GetMemberBinder binder, out object result) => throw null;
            public virtual bool TryInvoke(System.Dynamic.InvokeBinder binder, object[] args, out object result) => throw null;
            public virtual bool TryInvokeMember(System.Dynamic.InvokeMemberBinder binder, object[] args, out object result) => throw null;
            public virtual bool TrySetIndex(System.Dynamic.SetIndexBinder binder, object[] indexes, object value) => throw null;
            public virtual bool TrySetMember(System.Dynamic.SetMemberBinder binder, object value) => throw null;
            public virtual bool TryUnaryOperation(System.Dynamic.UnaryOperationBinder binder, out object result) => throw null;
        }
        public sealed class ExpandoObject : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Dynamic.IDynamicMetaObjectProvider, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable, System.ComponentModel.INotifyPropertyChanged
        {
            void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>.Add(System.Collections.Generic.KeyValuePair<string, object> item) => throw null;
            void System.Collections.Generic.IDictionary<string, object>.Add(string key, object value) => throw null;
            void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>.Clear() => throw null;
            bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>.Contains(System.Collections.Generic.KeyValuePair<string, object> item) => throw null;
            bool System.Collections.Generic.IDictionary<string, object>.ContainsKey(string key) => throw null;
            void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>.CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int arrayIndex) => throw null;
            int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>.Count { get => throw null; }
            public ExpandoObject() => throw null;
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>.GetEnumerator() => throw null;
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw null;
            System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) => throw null;
            bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>.IsReadOnly { get => throw null; }
            object System.Collections.Generic.IDictionary<string, object>.this[string key] { get => throw null; set { } }
            System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<string, object>.Keys { get => throw null; }
            event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged { add { } remove { } }
            bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>.Remove(System.Collections.Generic.KeyValuePair<string, object> item) => throw null;
            bool System.Collections.Generic.IDictionary<string, object>.Remove(string key) => throw null;
            bool System.Collections.Generic.IDictionary<string, object>.TryGetValue(string key, out object value) => throw null;
            System.Collections.Generic.ICollection<object> System.Collections.Generic.IDictionary<string, object>.Values { get => throw null; }
        }
        public abstract class GetIndexBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public System.Dynamic.CallInfo CallInfo { get => throw null; }
            protected GetIndexBinder(System.Dynamic.CallInfo callInfo) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackGetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackGetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject errorSuggestion);
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public abstract class GetMemberBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            protected GetMemberBinder(string name, bool ignoreCase) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
            public bool IgnoreCase { get => throw null; }
            public string Name { get => throw null; }
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public interface IDynamicMetaObjectProvider
        {
            System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
        }
        public interface IInvokeOnGetBinder
        {
            bool InvokeOnGet { get; }
        }
        public abstract class InvokeBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public System.Dynamic.CallInfo CallInfo { get => throw null; }
            protected InvokeBinder(System.Dynamic.CallInfo callInfo) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion);
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public abstract class InvokeMemberBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public System.Dynamic.CallInfo CallInfo { get => throw null; }
            protected InvokeMemberBinder(string name, bool ignoreCase, System.Dynamic.CallInfo callInfo) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion);
            public System.Dynamic.DynamicMetaObject FallbackInvokeMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackInvokeMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion);
            public bool IgnoreCase { get => throw null; }
            public string Name { get => throw null; }
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public abstract class SetIndexBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            public System.Dynamic.CallInfo CallInfo { get => throw null; }
            protected SetIndexBinder(System.Dynamic.CallInfo callInfo) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackSetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackSetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion);
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public abstract class SetMemberBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            protected SetMemberBinder(string name, bool ignoreCase) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion);
            public bool IgnoreCase { get => throw null; }
            public string Name { get => throw null; }
            public override sealed System.Type ReturnType { get => throw null; }
        }
        public abstract class UnaryOperationBinder : System.Dynamic.DynamicMetaObjectBinder
        {
            public override sealed System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) => throw null;
            protected UnaryOperationBinder(System.Linq.Expressions.ExpressionType operation) => throw null;
            public System.Dynamic.DynamicMetaObject FallbackUnaryOperation(System.Dynamic.DynamicMetaObject target) => throw null;
            public abstract System.Dynamic.DynamicMetaObject FallbackUnaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
            public System.Linq.Expressions.ExpressionType Operation { get => throw null; }
            public override sealed System.Type ReturnType { get => throw null; }
        }
    }
    namespace Linq
    {
        namespace Expressions
        {
            public class BinaryExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public override bool CanReduce { get => throw null; }
                public System.Linq.Expressions.LambdaExpression Conversion { get => throw null; }
                public bool IsLifted { get => throw null; }
                public bool IsLiftedToNull { get => throw null; }
                public System.Linq.Expressions.Expression Left { get => throw null; }
                public System.Reflection.MethodInfo Method { get => throw null; }
                public override System.Linq.Expressions.Expression Reduce() => throw null;
                public System.Linq.Expressions.Expression Right { get => throw null; }
                public System.Linq.Expressions.BinaryExpression Update(System.Linq.Expressions.Expression left, System.Linq.Expressions.LambdaExpression conversion, System.Linq.Expressions.Expression right) => throw null;
            }
            public class BlockExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Expressions { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Linq.Expressions.Expression Result { get => throw null; }
                public override System.Type Type { get => throw null; }
                public System.Linq.Expressions.BlockExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> Variables { get => throw null; }
            }
            public sealed class CatchBlock
            {
                public System.Linq.Expressions.Expression Body { get => throw null; }
                public System.Linq.Expressions.Expression Filter { get => throw null; }
                public System.Type Test { get => throw null; }
                public override string ToString() => throw null;
                public System.Linq.Expressions.CatchBlock Update(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression filter, System.Linq.Expressions.Expression body) => throw null;
                public System.Linq.Expressions.ParameterExpression Variable { get => throw null; }
            }
            public class ConditionalExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Linq.Expressions.Expression IfFalse { get => throw null; }
                public System.Linq.Expressions.Expression IfTrue { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Linq.Expressions.Expression Test { get => throw null; }
                public override System.Type Type { get => throw null; }
                public System.Linq.Expressions.ConditionalExpression Update(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) => throw null;
            }
            public class ConstantExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override System.Type Type { get => throw null; }
                public object Value { get => throw null; }
            }
            public class DebugInfoExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Linq.Expressions.SymbolDocumentInfo Document { get => throw null; }
                public virtual int EndColumn { get => throw null; }
                public virtual int EndLine { get => throw null; }
                public virtual bool IsClear { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public virtual int StartColumn { get => throw null; }
                public virtual int StartLine { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
            }
            public sealed class DefaultExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
            }
            public class DynamicExpression : System.Linq.Expressions.Expression, System.Linq.Expressions.IArgumentProvider, System.Linq.Expressions.IDynamicExpression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get => throw null; }
                public System.Runtime.CompilerServices.CallSiteBinder Binder { get => throw null; }
                object System.Linq.Expressions.IDynamicExpression.CreateCallSite() => throw null;
                public System.Type DelegateType { get => throw null; }
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, params System.Linq.Expressions.Expression[] arguments) => throw null;
                System.Linq.Expressions.Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                System.Linq.Expressions.Expression System.Linq.Expressions.IDynamicExpression.Rewrite(System.Linq.Expressions.Expression[] args) => throw null;
                public override System.Type Type { get => throw null; }
                public System.Linq.Expressions.DynamicExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
            }
            public abstract class DynamicExpressionVisitor : System.Linq.Expressions.ExpressionVisitor
            {
                protected DynamicExpressionVisitor() => throw null;
                protected override System.Linq.Expressions.Expression VisitDynamic(System.Linq.Expressions.DynamicExpression node) => throw null;
            }
            public sealed class ElementInit : System.Linq.Expressions.IArgumentProvider
            {
                public System.Reflection.MethodInfo AddMethod { get => throw null; }
                int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get => throw null; }
                System.Linq.Expressions.Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) => throw null;
                public override string ToString() => throw null;
                public System.Linq.Expressions.ElementInit Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
            }
            public abstract class Expression
            {
                protected virtual System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public static System.Linq.Expressions.BinaryExpression Add(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression Add(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression AddAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression AddAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression AddAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.BinaryExpression AddAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression AddAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression AddAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.BinaryExpression AddChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression AddChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression And(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression And(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression AndAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression AndAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression AndAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.IndexExpression ArrayAccess(System.Linq.Expressions.Expression array, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> indexes) => throw null;
                public static System.Linq.Expressions.IndexExpression ArrayAccess(System.Linq.Expressions.Expression array, params System.Linq.Expressions.Expression[] indexes) => throw null;
                public static System.Linq.Expressions.MethodCallExpression ArrayIndex(System.Linq.Expressions.Expression array, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> indexes) => throw null;
                public static System.Linq.Expressions.BinaryExpression ArrayIndex(System.Linq.Expressions.Expression array, System.Linq.Expressions.Expression index) => throw null;
                public static System.Linq.Expressions.MethodCallExpression ArrayIndex(System.Linq.Expressions.Expression array, params System.Linq.Expressions.Expression[] indexes) => throw null;
                public static System.Linq.Expressions.UnaryExpression ArrayLength(System.Linq.Expressions.Expression array) => throw null;
                public static System.Linq.Expressions.BinaryExpression Assign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.MemberAssignment Bind(System.Reflection.MemberInfo member, System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.MemberAssignment Bind(System.Reflection.MethodInfo propertyAccessor, System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, params System.Linq.Expressions.Expression[] expressions) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(params System.Linq.Expressions.Expression[] expressions) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, params System.Linq.Expressions.Expression[] expressions) => throw null;
                public static System.Linq.Expressions.BlockExpression Block(System.Type type, params System.Linq.Expressions.Expression[] expressions) => throw null;
                public static System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target) => throw null;
                public static System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) => throw null;
                public static System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) => throw null;
                public static System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target, System.Type type) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, string methodName, System.Type[] typeArguments, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.MethodCallExpression Call(System.Type type, string methodName, System.Type[] typeArguments, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public virtual bool CanReduce { get => throw null; }
                public static System.Linq.Expressions.CatchBlock Catch(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body) => throw null;
                public static System.Linq.Expressions.CatchBlock Catch(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter) => throw null;
                public static System.Linq.Expressions.CatchBlock Catch(System.Type type, System.Linq.Expressions.Expression body) => throw null;
                public static System.Linq.Expressions.CatchBlock Catch(System.Type type, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter) => throw null;
                public static System.Linq.Expressions.DebugInfoExpression ClearDebugInfo(System.Linq.Expressions.SymbolDocumentInfo document) => throw null;
                public static System.Linq.Expressions.BinaryExpression Coalesce(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression Coalesce(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.ConditionalExpression Condition(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) => throw null;
                public static System.Linq.Expressions.ConditionalExpression Condition(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse, System.Type type) => throw null;
                public static System.Linq.Expressions.ConstantExpression Constant(object value) => throw null;
                public static System.Linq.Expressions.ConstantExpression Constant(object value, System.Type type) => throw null;
                public static System.Linq.Expressions.GotoExpression Continue(System.Linq.Expressions.LabelTarget target) => throw null;
                public static System.Linq.Expressions.GotoExpression Continue(System.Linq.Expressions.LabelTarget target, System.Type type) => throw null;
                public static System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type) => throw null;
                public static System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.UnaryExpression ConvertChecked(System.Linq.Expressions.Expression expression, System.Type type) => throw null;
                public static System.Linq.Expressions.UnaryExpression ConvertChecked(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method) => throw null;
                protected Expression() => throw null;
                protected Expression(System.Linq.Expressions.ExpressionType nodeType, System.Type type) => throw null;
                public static System.Linq.Expressions.DebugInfoExpression DebugInfo(System.Linq.Expressions.SymbolDocumentInfo document, int startLine, int startColumn, int endLine, int endColumn) => throw null;
                public static System.Linq.Expressions.UnaryExpression Decrement(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression Decrement(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.DefaultExpression Default(System.Type type) => throw null;
                public static System.Linq.Expressions.BinaryExpression Divide(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression Divide(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression DivideAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression DivideAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression DivideAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) => throw null;
                public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.ElementInit ElementInit(System.Reflection.MethodInfo addMethod, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.ElementInit ElementInit(System.Reflection.MethodInfo addMethod, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.DefaultExpression Empty() => throw null;
                public static System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression ExclusiveOr(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression ExclusiveOr(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression ExclusiveOrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression ExclusiveOrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression ExclusiveOrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, System.Reflection.FieldInfo field) => throw null;
                public static System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, string fieldName) => throw null;
                public static System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, System.Type type, string fieldName) => throw null;
                public static System.Type GetActionType(params System.Type[] typeArgs) => throw null;
                public static System.Type GetDelegateType(params System.Type[] typeArgs) => throw null;
                public static System.Type GetFuncType(params System.Type[] typeArgs) => throw null;
                public static System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target) => throw null;
                public static System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) => throw null;
                public static System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) => throw null;
                public static System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Type type) => throw null;
                public static System.Linq.Expressions.BinaryExpression GreaterThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression GreaterThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression GreaterThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression GreaterThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.ConditionalExpression IfThen(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue) => throw null;
                public static System.Linq.Expressions.ConditionalExpression IfThenElse(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) => throw null;
                public static System.Linq.Expressions.UnaryExpression Increment(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression Increment(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.UnaryExpression IsFalse(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression IsFalse(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.UnaryExpression IsTrue(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression IsTrue(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.LabelTarget Label() => throw null;
                public static System.Linq.Expressions.LabelExpression Label(System.Linq.Expressions.LabelTarget target) => throw null;
                public static System.Linq.Expressions.LabelExpression Label(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression defaultValue) => throw null;
                public static System.Linq.Expressions.LabelTarget Label(string name) => throw null;
                public static System.Linq.Expressions.LabelTarget Label(System.Type type) => throw null;
                public static System.Linq.Expressions.LabelTarget Label(System.Type type, string name) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, bool tailCall, params System.Linq.Expressions.ParameterExpression[] parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, params System.Linq.Expressions.ParameterExpression[] parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, string name, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, string name, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, bool tailCall, params System.Linq.Expressions.ParameterExpression[] parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, params System.Linq.Expressions.ParameterExpression[] parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, string name, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, string name, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, bool tailCall, params System.Linq.Expressions.ParameterExpression[] parameters) => throw null;
                public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, params System.Linq.Expressions.ParameterExpression[] parameters) => throw null;
                public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, string name, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, string name, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
                public static System.Linq.Expressions.BinaryExpression LeftShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression LeftShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression LeftShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression LeftShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression LeftShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.BinaryExpression LessThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression LessThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression LessThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression LessThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.MemberListBinding ListBind(System.Reflection.MemberInfo member, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) => throw null;
                public static System.Linq.Expressions.MemberListBinding ListBind(System.Reflection.MemberInfo member, params System.Linq.Expressions.ElementInit[] initializers) => throw null;
                public static System.Linq.Expressions.MemberListBinding ListBind(System.Reflection.MethodInfo propertyAccessor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) => throw null;
                public static System.Linq.Expressions.MemberListBinding ListBind(System.Reflection.MethodInfo propertyAccessor, params System.Linq.Expressions.ElementInit[] initializers) => throw null;
                public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) => throw null;
                public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> initializers) => throw null;
                public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, params System.Linq.Expressions.ElementInit[] initializers) => throw null;
                public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, params System.Linq.Expressions.Expression[] initializers) => throw null;
                public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, System.Reflection.MethodInfo addMethod, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> initializers) => throw null;
                public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, System.Reflection.MethodInfo addMethod, params System.Linq.Expressions.Expression[] initializers) => throw null;
                public static System.Linq.Expressions.LoopExpression Loop(System.Linq.Expressions.Expression body) => throw null;
                public static System.Linq.Expressions.LoopExpression Loop(System.Linq.Expressions.Expression body, System.Linq.Expressions.LabelTarget @break) => throw null;
                public static System.Linq.Expressions.LoopExpression Loop(System.Linq.Expressions.Expression body, System.Linq.Expressions.LabelTarget @break, System.Linq.Expressions.LabelTarget @continue) => throw null;
                public static System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.CatchBlock MakeCatchBlock(System.Type type, System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) => throw null;
                public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.GotoExpression MakeGoto(System.Linq.Expressions.GotoExpressionKind kind, System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) => throw null;
                public static System.Linq.Expressions.IndexExpression MakeIndex(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.MemberExpression MakeMemberAccess(System.Linq.Expressions.Expression expression, System.Reflection.MemberInfo member) => throw null;
                public static System.Linq.Expressions.TryExpression MakeTry(System.Type type, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression @finally, System.Linq.Expressions.Expression fault, System.Collections.Generic.IEnumerable<System.Linq.Expressions.CatchBlock> handlers) => throw null;
                public static System.Linq.Expressions.UnaryExpression MakeUnary(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Type type) => throw null;
                public static System.Linq.Expressions.UnaryExpression MakeUnary(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Type type, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.MemberMemberBinding MemberBind(System.Reflection.MemberInfo member, System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) => throw null;
                public static System.Linq.Expressions.MemberMemberBinding MemberBind(System.Reflection.MemberInfo member, params System.Linq.Expressions.MemberBinding[] bindings) => throw null;
                public static System.Linq.Expressions.MemberMemberBinding MemberBind(System.Reflection.MethodInfo propertyAccessor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) => throw null;
                public static System.Linq.Expressions.MemberMemberBinding MemberBind(System.Reflection.MethodInfo propertyAccessor, params System.Linq.Expressions.MemberBinding[] bindings) => throw null;
                public static System.Linq.Expressions.MemberInitExpression MemberInit(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) => throw null;
                public static System.Linq.Expressions.MemberInitExpression MemberInit(System.Linq.Expressions.NewExpression newExpression, params System.Linq.Expressions.MemberBinding[] bindings) => throw null;
                public static System.Linq.Expressions.BinaryExpression Modulo(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression Modulo(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression ModuloAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression ModuloAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression ModuloAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.BinaryExpression Multiply(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression Multiply(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression MultiplyAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression MultiplyAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression MultiplyAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.BinaryExpression MultiplyAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression MultiplyAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression MultiplyAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.BinaryExpression MultiplyChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression MultiplyChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.UnaryExpression Negate(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression Negate(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.UnaryExpression NegateChecked(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression NegateChecked(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor) => throw null;
                public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments, System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> members) => throw null;
                public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments, params System.Reflection.MemberInfo[] members) => throw null;
                public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.NewExpression New(System.Type type) => throw null;
                public static System.Linq.Expressions.NewArrayExpression NewArrayBounds(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> bounds) => throw null;
                public static System.Linq.Expressions.NewArrayExpression NewArrayBounds(System.Type type, params System.Linq.Expressions.Expression[] bounds) => throw null;
                public static System.Linq.Expressions.NewArrayExpression NewArrayInit(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> initializers) => throw null;
                public static System.Linq.Expressions.NewArrayExpression NewArrayInit(System.Type type, params System.Linq.Expressions.Expression[] initializers) => throw null;
                public virtual System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public static System.Linq.Expressions.UnaryExpression Not(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression Not(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression NotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression NotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.UnaryExpression OnesComplement(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression OnesComplement(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression Or(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression Or(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression OrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression OrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression OrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.BinaryExpression OrElse(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression OrElse(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.ParameterExpression Parameter(System.Type type) => throw null;
                public static System.Linq.Expressions.ParameterExpression Parameter(System.Type type, string name) => throw null;
                public static System.Linq.Expressions.UnaryExpression PostDecrementAssign(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression PostDecrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.UnaryExpression PostIncrementAssign(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression PostIncrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression Power(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression Power(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression PowerAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression PowerAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression PowerAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.UnaryExpression PreDecrementAssign(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression PreDecrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.UnaryExpression PreIncrementAssign(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression PreIncrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo propertyAccessor) => throw null;
                public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.PropertyInfo property) => throw null;
                public static System.Linq.Expressions.IndexExpression Property(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
                public static System.Linq.Expressions.IndexExpression Property(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, string propertyName) => throw null;
                public static System.Linq.Expressions.IndexExpression Property(System.Linq.Expressions.Expression instance, string propertyName, params System.Linq.Expressions.Expression[] arguments) => throw null;
                public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Type type, string propertyName) => throw null;
                public static System.Linq.Expressions.MemberExpression PropertyOrField(System.Linq.Expressions.Expression expression, string propertyOrFieldName) => throw null;
                public static System.Linq.Expressions.UnaryExpression Quote(System.Linq.Expressions.Expression expression) => throw null;
                public virtual System.Linq.Expressions.Expression Reduce() => throw null;
                public System.Linq.Expressions.Expression ReduceAndCheck() => throw null;
                public System.Linq.Expressions.Expression ReduceExtensions() => throw null;
                public static System.Linq.Expressions.BinaryExpression ReferenceEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression ReferenceNotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.UnaryExpression Rethrow() => throw null;
                public static System.Linq.Expressions.UnaryExpression Rethrow(System.Type type) => throw null;
                public static System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target) => throw null;
                public static System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) => throw null;
                public static System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) => throw null;
                public static System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target, System.Type type) => throw null;
                public static System.Linq.Expressions.BinaryExpression RightShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression RightShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression RightShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression RightShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression RightShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.RuntimeVariablesExpression RuntimeVariables(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables) => throw null;
                public static System.Linq.Expressions.RuntimeVariablesExpression RuntimeVariables(params System.Linq.Expressions.ParameterExpression[] variables) => throw null;
                public static System.Linq.Expressions.BinaryExpression Subtract(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression Subtract(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression SubtractAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression SubtractAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression SubtractAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.BinaryExpression SubtractAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression SubtractAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.BinaryExpression SubtractAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) => throw null;
                public static System.Linq.Expressions.BinaryExpression SubtractChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) => throw null;
                public static System.Linq.Expressions.BinaryExpression SubtractChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.SwitchExpression Switch(System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, params System.Linq.Expressions.SwitchCase[] cases) => throw null;
                public static System.Linq.Expressions.SwitchExpression Switch(System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, System.Reflection.MethodInfo comparison, System.Collections.Generic.IEnumerable<System.Linq.Expressions.SwitchCase> cases) => throw null;
                public static System.Linq.Expressions.SwitchExpression Switch(System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, System.Reflection.MethodInfo comparison, params System.Linq.Expressions.SwitchCase[] cases) => throw null;
                public static System.Linq.Expressions.SwitchExpression Switch(System.Linq.Expressions.Expression switchValue, params System.Linq.Expressions.SwitchCase[] cases) => throw null;
                public static System.Linq.Expressions.SwitchExpression Switch(System.Type type, System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, System.Reflection.MethodInfo comparison, System.Collections.Generic.IEnumerable<System.Linq.Expressions.SwitchCase> cases) => throw null;
                public static System.Linq.Expressions.SwitchExpression Switch(System.Type type, System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, System.Reflection.MethodInfo comparison, params System.Linq.Expressions.SwitchCase[] cases) => throw null;
                public static System.Linq.Expressions.SwitchCase SwitchCase(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> testValues) => throw null;
                public static System.Linq.Expressions.SwitchCase SwitchCase(System.Linq.Expressions.Expression body, params System.Linq.Expressions.Expression[] testValues) => throw null;
                public static System.Linq.Expressions.SymbolDocumentInfo SymbolDocument(string fileName) => throw null;
                public static System.Linq.Expressions.SymbolDocumentInfo SymbolDocument(string fileName, System.Guid language) => throw null;
                public static System.Linq.Expressions.SymbolDocumentInfo SymbolDocument(string fileName, System.Guid language, System.Guid languageVendor) => throw null;
                public static System.Linq.Expressions.SymbolDocumentInfo SymbolDocument(string fileName, System.Guid language, System.Guid languageVendor, System.Guid documentType) => throw null;
                public static System.Linq.Expressions.UnaryExpression Throw(System.Linq.Expressions.Expression value) => throw null;
                public static System.Linq.Expressions.UnaryExpression Throw(System.Linq.Expressions.Expression value, System.Type type) => throw null;
                public override string ToString() => throw null;
                public static System.Linq.Expressions.TryExpression TryCatch(System.Linq.Expressions.Expression body, params System.Linq.Expressions.CatchBlock[] handlers) => throw null;
                public static System.Linq.Expressions.TryExpression TryCatchFinally(System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression @finally, params System.Linq.Expressions.CatchBlock[] handlers) => throw null;
                public static System.Linq.Expressions.TryExpression TryFault(System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression fault) => throw null;
                public static System.Linq.Expressions.TryExpression TryFinally(System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression @finally) => throw null;
                public static bool TryGetActionType(System.Type[] typeArgs, out System.Type actionType) => throw null;
                public static bool TryGetFuncType(System.Type[] typeArgs, out System.Type funcType) => throw null;
                public virtual System.Type Type { get => throw null; }
                public static System.Linq.Expressions.UnaryExpression TypeAs(System.Linq.Expressions.Expression expression, System.Type type) => throw null;
                public static System.Linq.Expressions.TypeBinaryExpression TypeEqual(System.Linq.Expressions.Expression expression, System.Type type) => throw null;
                public static System.Linq.Expressions.TypeBinaryExpression TypeIs(System.Linq.Expressions.Expression expression, System.Type type) => throw null;
                public static System.Linq.Expressions.UnaryExpression UnaryPlus(System.Linq.Expressions.Expression expression) => throw null;
                public static System.Linq.Expressions.UnaryExpression UnaryPlus(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) => throw null;
                public static System.Linq.Expressions.UnaryExpression Unbox(System.Linq.Expressions.Expression expression, System.Type type) => throw null;
                public static System.Linq.Expressions.ParameterExpression Variable(System.Type type) => throw null;
                public static System.Linq.Expressions.ParameterExpression Variable(System.Type type, string name) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitChildren(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
            }
            public sealed class Expression<TDelegate> : System.Linq.Expressions.LambdaExpression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public TDelegate Compile() => throw null;
                public TDelegate Compile(bool preferInterpretation) => throw null;
                public TDelegate Compile(System.Runtime.CompilerServices.DebugInfoGenerator debugInfoGenerator) => throw null;
                public System.Linq.Expressions.Expression<TDelegate> Update(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) => throw null;
            }
            public enum ExpressionType
            {
                Add = 0,
                AddChecked = 1,
                And = 2,
                AndAlso = 3,
                ArrayLength = 4,
                ArrayIndex = 5,
                Call = 6,
                Coalesce = 7,
                Conditional = 8,
                Constant = 9,
                Convert = 10,
                ConvertChecked = 11,
                Divide = 12,
                Equal = 13,
                ExclusiveOr = 14,
                GreaterThan = 15,
                GreaterThanOrEqual = 16,
                Invoke = 17,
                Lambda = 18,
                LeftShift = 19,
                LessThan = 20,
                LessThanOrEqual = 21,
                ListInit = 22,
                MemberAccess = 23,
                MemberInit = 24,
                Modulo = 25,
                Multiply = 26,
                MultiplyChecked = 27,
                Negate = 28,
                UnaryPlus = 29,
                NegateChecked = 30,
                New = 31,
                NewArrayInit = 32,
                NewArrayBounds = 33,
                Not = 34,
                NotEqual = 35,
                Or = 36,
                OrElse = 37,
                Parameter = 38,
                Power = 39,
                Quote = 40,
                RightShift = 41,
                Subtract = 42,
                SubtractChecked = 43,
                TypeAs = 44,
                TypeIs = 45,
                Assign = 46,
                Block = 47,
                DebugInfo = 48,
                Decrement = 49,
                Dynamic = 50,
                Default = 51,
                Extension = 52,
                Goto = 53,
                Increment = 54,
                Index = 55,
                Label = 56,
                RuntimeVariables = 57,
                Loop = 58,
                Switch = 59,
                Throw = 60,
                Try = 61,
                Unbox = 62,
                AddAssign = 63,
                AndAssign = 64,
                DivideAssign = 65,
                ExclusiveOrAssign = 66,
                LeftShiftAssign = 67,
                ModuloAssign = 68,
                MultiplyAssign = 69,
                OrAssign = 70,
                PowerAssign = 71,
                RightShiftAssign = 72,
                SubtractAssign = 73,
                AddAssignChecked = 74,
                MultiplyAssignChecked = 75,
                SubtractAssignChecked = 76,
                PreIncrementAssign = 77,
                PreDecrementAssign = 78,
                PostIncrementAssign = 79,
                PostDecrementAssign = 80,
                TypeEqual = 81,
                OnesComplement = 82,
                IsTrue = 83,
                IsFalse = 84,
            }
            public abstract class ExpressionVisitor
            {
                protected ExpressionVisitor() => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Visit(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> nodes) => throw null;
                public virtual System.Linq.Expressions.Expression Visit(System.Linq.Expressions.Expression node) => throw null;
                public static System.Collections.ObjectModel.ReadOnlyCollection<T> Visit<T>(System.Collections.ObjectModel.ReadOnlyCollection<T> nodes, System.Func<T, T> elementVisitor) => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<T> VisitAndConvert<T>(System.Collections.ObjectModel.ReadOnlyCollection<T> nodes, string callerName) where T : System.Linq.Expressions.Expression => throw null;
                public T VisitAndConvert<T>(T node, string callerName) where T : System.Linq.Expressions.Expression => throw null;
                protected virtual System.Linq.Expressions.Expression VisitBinary(System.Linq.Expressions.BinaryExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node) => throw null;
                protected virtual System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitDebugInfo(System.Linq.Expressions.DebugInfoExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitDefault(System.Linq.Expressions.DefaultExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitDynamic(System.Linq.Expressions.DynamicExpression node) => throw null;
                protected virtual System.Linq.Expressions.ElementInit VisitElementInit(System.Linq.Expressions.ElementInit node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitExtension(System.Linq.Expressions.Expression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitGoto(System.Linq.Expressions.GotoExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitIndex(System.Linq.Expressions.IndexExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitInvocation(System.Linq.Expressions.InvocationExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitLabel(System.Linq.Expressions.LabelExpression node) => throw null;
                protected virtual System.Linq.Expressions.LabelTarget VisitLabelTarget(System.Linq.Expressions.LabelTarget node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitLambda<T>(System.Linq.Expressions.Expression<T> node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitListInit(System.Linq.Expressions.ListInitExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitLoop(System.Linq.Expressions.LoopExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitMember(System.Linq.Expressions.MemberExpression node) => throw null;
                protected virtual System.Linq.Expressions.MemberAssignment VisitMemberAssignment(System.Linq.Expressions.MemberAssignment node) => throw null;
                protected virtual System.Linq.Expressions.MemberBinding VisitMemberBinding(System.Linq.Expressions.MemberBinding node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitMemberInit(System.Linq.Expressions.MemberInitExpression node) => throw null;
                protected virtual System.Linq.Expressions.MemberListBinding VisitMemberListBinding(System.Linq.Expressions.MemberListBinding node) => throw null;
                protected virtual System.Linq.Expressions.MemberMemberBinding VisitMemberMemberBinding(System.Linq.Expressions.MemberMemberBinding node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitMethodCall(System.Linq.Expressions.MethodCallExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitNew(System.Linq.Expressions.NewExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitNewArray(System.Linq.Expressions.NewArrayExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitRuntimeVariables(System.Linq.Expressions.RuntimeVariablesExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitSwitch(System.Linq.Expressions.SwitchExpression node) => throw null;
                protected virtual System.Linq.Expressions.SwitchCase VisitSwitchCase(System.Linq.Expressions.SwitchCase node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitTry(System.Linq.Expressions.TryExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitTypeBinary(System.Linq.Expressions.TypeBinaryExpression node) => throw null;
                protected virtual System.Linq.Expressions.Expression VisitUnary(System.Linq.Expressions.UnaryExpression node) => throw null;
            }
            public sealed class GotoExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Linq.Expressions.GotoExpressionKind Kind { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Linq.Expressions.LabelTarget Target { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.GotoExpression Update(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) => throw null;
                public System.Linq.Expressions.Expression Value { get => throw null; }
            }
            public enum GotoExpressionKind
            {
                Goto = 0,
                Return = 1,
                Break = 2,
                Continue = 3,
            }
            public interface IArgumentProvider
            {
                int ArgumentCount { get; }
                System.Linq.Expressions.Expression GetArgument(int index);
            }
            public interface IDynamicExpression : System.Linq.Expressions.IArgumentProvider
            {
                object CreateCallSite();
                System.Type DelegateType { get; }
                System.Linq.Expressions.Expression Rewrite(System.Linq.Expressions.Expression[] args);
            }
            public sealed class IndexExpression : System.Linq.Expressions.Expression, System.Linq.Expressions.IArgumentProvider
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get => throw null; }
                System.Linq.Expressions.Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) => throw null;
                public System.Reflection.PropertyInfo Indexer { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Linq.Expressions.Expression Object { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.IndexExpression Update(System.Linq.Expressions.Expression @object, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
            }
            public sealed class InvocationExpression : System.Linq.Expressions.Expression, System.Linq.Expressions.IArgumentProvider
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get => throw null; }
                public System.Linq.Expressions.Expression Expression { get => throw null; }
                System.Linq.Expressions.Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) => throw null;
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.InvocationExpression Update(System.Linq.Expressions.Expression expression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
            }
            public sealed class LabelExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Linq.Expressions.Expression DefaultValue { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Linq.Expressions.LabelTarget Target { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.LabelExpression Update(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression defaultValue) => throw null;
            }
            public sealed class LabelTarget
            {
                public string Name { get => throw null; }
                public override string ToString() => throw null;
                public System.Type Type { get => throw null; }
            }
            public abstract class LambdaExpression : System.Linq.Expressions.Expression
            {
                public System.Linq.Expressions.Expression Body { get => throw null; }
                public System.Delegate Compile() => throw null;
                public System.Delegate Compile(bool preferInterpretation) => throw null;
                public System.Delegate Compile(System.Runtime.CompilerServices.DebugInfoGenerator debugInfoGenerator) => throw null;
                public string Name { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> Parameters { get => throw null; }
                public System.Type ReturnType { get => throw null; }
                public bool TailCall { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
            }
            public sealed class ListInitExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public override bool CanReduce { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> Initializers { get => throw null; }
                public System.Linq.Expressions.NewExpression NewExpression { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override System.Linq.Expressions.Expression Reduce() => throw null;
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.ListInitExpression Update(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) => throw null;
            }
            public sealed class LoopExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Linq.Expressions.Expression Body { get => throw null; }
                public System.Linq.Expressions.LabelTarget BreakLabel { get => throw null; }
                public System.Linq.Expressions.LabelTarget ContinueLabel { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.LoopExpression Update(System.Linq.Expressions.LabelTarget breakLabel, System.Linq.Expressions.LabelTarget continueLabel, System.Linq.Expressions.Expression body) => throw null;
            }
            public sealed class MemberAssignment : System.Linq.Expressions.MemberBinding
            {
                public System.Linq.Expressions.Expression Expression { get => throw null; }
                public System.Linq.Expressions.MemberAssignment Update(System.Linq.Expressions.Expression expression) => throw null;
                internal MemberAssignment() : base(default(System.Linq.Expressions.MemberBindingType), default(System.Reflection.MemberInfo)) { }
            }
            public abstract class MemberBinding
            {
                public System.Linq.Expressions.MemberBindingType BindingType { get => throw null; }
                protected MemberBinding(System.Linq.Expressions.MemberBindingType type, System.Reflection.MemberInfo member) => throw null;
                public System.Reflection.MemberInfo Member { get => throw null; }
                public override string ToString() => throw null;
            }
            public enum MemberBindingType
            {
                Assignment = 0,
                MemberBinding = 1,
                ListBinding = 2,
            }
            public class MemberExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Linq.Expressions.Expression Expression { get => throw null; }
                public System.Reflection.MemberInfo Member { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Linq.Expressions.MemberExpression Update(System.Linq.Expressions.Expression expression) => throw null;
            }
            public sealed class MemberInitExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> Bindings { get => throw null; }
                public override bool CanReduce { get => throw null; }
                public System.Linq.Expressions.NewExpression NewExpression { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override System.Linq.Expressions.Expression Reduce() => throw null;
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.MemberInitExpression Update(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) => throw null;
            }
            public sealed class MemberListBinding : System.Linq.Expressions.MemberBinding
            {
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> Initializers { get => throw null; }
                public System.Linq.Expressions.MemberListBinding Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) => throw null;
                internal MemberListBinding() : base(default(System.Linq.Expressions.MemberBindingType), default(System.Reflection.MemberInfo)) { }
            }
            public sealed class MemberMemberBinding : System.Linq.Expressions.MemberBinding
            {
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> Bindings { get => throw null; }
                public System.Linq.Expressions.MemberMemberBinding Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) => throw null;
                internal MemberMemberBinding() : base(default(System.Linq.Expressions.MemberBindingType), default(System.Reflection.MemberInfo)) { }
            }
            public class MethodCallExpression : System.Linq.Expressions.Expression, System.Linq.Expressions.IArgumentProvider
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get => throw null; }
                System.Linq.Expressions.Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) => throw null;
                public System.Reflection.MethodInfo Method { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Linq.Expressions.Expression Object { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.MethodCallExpression Update(System.Linq.Expressions.Expression @object, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
            }
            public class NewArrayExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Expressions { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.NewArrayExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) => throw null;
            }
            public class NewExpression : System.Linq.Expressions.Expression, System.Linq.Expressions.IArgumentProvider
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get => throw null; }
                public System.Reflection.ConstructorInfo Constructor { get => throw null; }
                System.Linq.Expressions.Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MemberInfo> Members { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override System.Type Type { get => throw null; }
                public System.Linq.Expressions.NewExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) => throw null;
            }
            public class ParameterExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public bool IsByRef { get => throw null; }
                public string Name { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override System.Type Type { get => throw null; }
            }
            public sealed class RuntimeVariablesExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.RuntimeVariablesExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables) => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> Variables { get => throw null; }
            }
            public sealed class SwitchCase
            {
                public System.Linq.Expressions.Expression Body { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> TestValues { get => throw null; }
                public override string ToString() => throw null;
                public System.Linq.Expressions.SwitchCase Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> testValues, System.Linq.Expressions.Expression body) => throw null;
            }
            public sealed class SwitchExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase> Cases { get => throw null; }
                public System.Reflection.MethodInfo Comparison { get => throw null; }
                public System.Linq.Expressions.Expression DefaultBody { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Linq.Expressions.Expression SwitchValue { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.SwitchExpression Update(System.Linq.Expressions.Expression switchValue, System.Collections.Generic.IEnumerable<System.Linq.Expressions.SwitchCase> cases, System.Linq.Expressions.Expression defaultBody) => throw null;
            }
            public class SymbolDocumentInfo
            {
                public virtual System.Guid DocumentType { get => throw null; }
                public string FileName { get => throw null; }
                public virtual System.Guid Language { get => throw null; }
                public virtual System.Guid LanguageVendor { get => throw null; }
            }
            public sealed class TryExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Linq.Expressions.Expression Body { get => throw null; }
                public System.Linq.Expressions.Expression Fault { get => throw null; }
                public System.Linq.Expressions.Expression Finally { get => throw null; }
                public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock> Handlers { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.TryExpression Update(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.CatchBlock> handlers, System.Linq.Expressions.Expression @finally, System.Linq.Expressions.Expression fault) => throw null;
            }
            public sealed class TypeBinaryExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public System.Linq.Expressions.Expression Expression { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public override sealed System.Type Type { get => throw null; }
                public System.Type TypeOperand { get => throw null; }
                public System.Linq.Expressions.TypeBinaryExpression Update(System.Linq.Expressions.Expression expression) => throw null;
            }
            public sealed class UnaryExpression : System.Linq.Expressions.Expression
            {
                protected override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) => throw null;
                public override bool CanReduce { get => throw null; }
                public bool IsLifted { get => throw null; }
                public bool IsLiftedToNull { get => throw null; }
                public System.Reflection.MethodInfo Method { get => throw null; }
                public override sealed System.Linq.Expressions.ExpressionType NodeType { get => throw null; }
                public System.Linq.Expressions.Expression Operand { get => throw null; }
                public override System.Linq.Expressions.Expression Reduce() => throw null;
                public override sealed System.Type Type { get => throw null; }
                public System.Linq.Expressions.UnaryExpression Update(System.Linq.Expressions.Expression operand) => throw null;
            }
        }
        public interface IOrderedQueryable : System.Collections.IEnumerable, System.Linq.IQueryable
        {
        }
        public interface IOrderedQueryable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Linq.IOrderedQueryable, System.Linq.IQueryable, System.Linq.IQueryable<T>
        {
        }
        public interface IQueryable : System.Collections.IEnumerable
        {
            System.Type ElementType { get; }
            System.Linq.Expressions.Expression Expression { get; }
            System.Linq.IQueryProvider Provider { get; }
        }
        public interface IQueryable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Linq.IQueryable
        {
        }
        public interface IQueryProvider
        {
            System.Linq.IQueryable CreateQuery(System.Linq.Expressions.Expression expression);
            System.Linq.IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression);
            object Execute(System.Linq.Expressions.Expression expression);
            TResult Execute<TResult>(System.Linq.Expressions.Expression expression);
        }
    }
    namespace Runtime
    {
        namespace CompilerServices
        {
            public class CallSite
            {
                public System.Runtime.CompilerServices.CallSiteBinder Binder { get => throw null; }
                public static System.Runtime.CompilerServices.CallSite Create(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder) => throw null;
            }
            public class CallSite<T> : System.Runtime.CompilerServices.CallSite where T : class
            {
                public static System.Runtime.CompilerServices.CallSite<T> Create(System.Runtime.CompilerServices.CallSiteBinder binder) => throw null;
                public T Target;
                public T Update { get => throw null; }
            }
            public abstract class CallSiteBinder
            {
                public abstract System.Linq.Expressions.Expression Bind(object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Linq.Expressions.LabelTarget returnLabel);
                public virtual T BindDelegate<T>(System.Runtime.CompilerServices.CallSite<T> site, object[] args) where T : class => throw null;
                protected void CacheTarget<T>(T target) where T : class => throw null;
                protected CallSiteBinder() => throw null;
                public static System.Linq.Expressions.LabelTarget UpdateLabel { get => throw null; }
            }
            public static class CallSiteHelpers
            {
                public static bool IsInternalFrame(System.Reflection.MethodBase mb) => throw null;
            }
            public abstract class DebugInfoGenerator
            {
                public static System.Runtime.CompilerServices.DebugInfoGenerator CreatePdbGenerator() => throw null;
                protected DebugInfoGenerator() => throw null;
                public abstract void MarkSequencePoint(System.Linq.Expressions.LambdaExpression method, int ilOffset, System.Linq.Expressions.DebugInfoExpression sequencePoint);
            }
            public sealed class DynamicAttribute : System.Attribute
            {
                public DynamicAttribute() => throw null;
                public DynamicAttribute(bool[] transformFlags) => throw null;
                public System.Collections.Generic.IList<bool> TransformFlags { get => throw null; }
            }
            public interface IRuntimeVariables
            {
                int Count { get; }
                object this[int index] { get; set; }
            }
            public sealed class ReadOnlyCollectionBuilder<T> : System.Collections.Generic.ICollection<T>, System.Collections.ICollection, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IList<T>, System.Collections.IList
            {
                public void Add(T item) => throw null;
                int System.Collections.IList.Add(object value) => throw null;
                public int Capacity { get => throw null; set { } }
                public void Clear() => throw null;
                public bool Contains(T item) => throw null;
                bool System.Collections.IList.Contains(object value) => throw null;
                public void CopyTo(T[] array, int arrayIndex) => throw null;
                void System.Collections.ICollection.CopyTo(System.Array array, int index) => throw null;
                public int Count { get => throw null; }
                public ReadOnlyCollectionBuilder() => throw null;
                public ReadOnlyCollectionBuilder(System.Collections.Generic.IEnumerable<T> collection) => throw null;
                public ReadOnlyCollectionBuilder(int capacity) => throw null;
                public System.Collections.Generic.IEnumerator<T> GetEnumerator() => throw null;
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw null;
                public int IndexOf(T item) => throw null;
                int System.Collections.IList.IndexOf(object value) => throw null;
                public void Insert(int index, T item) => throw null;
                void System.Collections.IList.Insert(int index, object value) => throw null;
                bool System.Collections.IList.IsFixedSize { get => throw null; }
                bool System.Collections.Generic.ICollection<T>.IsReadOnly { get => throw null; }
                bool System.Collections.IList.IsReadOnly { get => throw null; }
                bool System.Collections.ICollection.IsSynchronized { get => throw null; }
                object System.Collections.IList.this[int index] { get => throw null; set { } }
                public bool Remove(T item) => throw null;
                void System.Collections.IList.Remove(object value) => throw null;
                public void RemoveAt(int index) => throw null;
                public void Reverse() => throw null;
                public void Reverse(int index, int count) => throw null;
                object System.Collections.ICollection.SyncRoot { get => throw null; }
                public T this[int index] { get => throw null; set { } }
                public T[] ToArray() => throw null;
                public System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnlyCollection() => throw null;
            }
            public class RuleCache<T> where T : class
            {
            }
        }
    }
}
