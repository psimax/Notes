public static class MayBe
    {
        public static TResult With<TInput, TResult>(this TInput o, Func<TInput, TResult> evaluator)
            where TResult : class
            where TInput : class
        {
            return o == null ? null : evaluator(o);
        }
 
        public static TResult Return<TInput, TResult>(this TInput o, Func<TInput, TResult> evaluator, TResult defaultValue) 
            where TInput : class
        {
            return o == null ? defaultValue : evaluator(o);
        }
    }