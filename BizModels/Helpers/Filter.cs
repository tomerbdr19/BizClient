using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BizModels.Helpers
{
    public abstract class IFilter : ObservableObject
    {
        public bool IsChecked { get; set; } = false;
        public string Key { get; set; }
        abstract public KeyValuePair<string, object> ToFilter();
    }

    public class RangeFilter<T> : IFilter
    {
        public T From { get; set; }
        public T To { get; set; }

        public override KeyValuePair<string, object> ToFilter()
        {
            return new KeyValuePair<string, object>(this.Key, new { From = this.From, To = this.To });
        }
    }

    public class OptionsFilter<T> : IFilter
    {
        public List<T> Options { get; set; }
        public T Value { get; set; }

        public override KeyValuePair<string, object> ToFilter()
        {
            return new KeyValuePair<string, object>(this.Key, this.Value);
        }
    }

    public static class FilterRequestGenerator
    {
        public static Dictionary<string, object> Generate(List<IFilter> filters)
        {
            IDictionary<string, object> dict = new Dictionary<string, object>();

            filters.ForEach((_) => dict.Add(_.ToFilter()));

            return (Dictionary<string, object>)dict;
        }
    }
}

