﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line (1,2)-(1,27) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(0, RenderPerson((person) => (__builder2) => {
    __builder2.OpenElement(1, "div");
#nullable restore
#line (1,34)-(1,45) 25 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder2.AddContent(2, person.Name);

#line default
#line hidden
#nullable disable
    __builder2.CloseElement();
}
));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    class Person
    {
        public string Name { get; set; }
    }

    object RenderPerson(RenderFragment<Person> p) => null;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
