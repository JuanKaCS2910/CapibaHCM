using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capiba.HCM.Shared.DTOs
{
    public class ListItemDTO
    {
        public string Icon { get; set; }
        public bool ShowOnSeed { get; set; } = true;
        public string Parent { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Href { get; set; }
        public ItemType Type { get; set; } = ItemType.Single;
        public string Route { get; set; }
        public string Tags { get; set; }
        public string I18n { get; set; }
        public bool Disabled { get; set; }
        public List<ListItemDTO> Items { set; get; } = new List<ListItemDTO>();
        public Span Span { get; set; } = new Span();
        public string[] Roles { get; set; }

        public bool ShowSelect { get; set; } = false;
    }

    public sealed class Span
    {
        public string Position { get; set; }
        public string Class { get; set; }
        public string Text { get; set; }

        public bool HasValue() => (Position?.Length ?? 0) + (Class?.Length ?? 0) + (Text?.Length ?? 0) > 0;
    }

    public enum ItemType
    {
        Category = 0,
        Single,
        Parent,
        Child
    }
}
