#pragma checksum "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b369af8e074c8cc246da909c58603f0067ab89c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Product/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\_ViewImports.cshtml"
using Geco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\_ViewImports.cshtml"
using Geco.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\_ViewImports.cshtml"
using Geco.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b369af8e074c8cc246da909c58603f0067ab89c7", @"/Areas/Manage/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd37af785b5a5b6de7ea6bd68473b44a5a2fd057", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mx-lg-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/cs/checkall.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/pages/orders.list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/common.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" aria-labelledby=""deleteModal"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""deleteModalLabel"">Silmək istədiyinizə əminsinizmi?</h5>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b369af8e074c8cc246da909c58603f0067ab89c77419", async() => {
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-outline-primary\">Yes</button>\r\n                <button type=\"button\" class=\"btn btn-outline-danger\" data-bs-dismiss=\"modal\">No</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""container"">
    <!-- Title and Top Buttons Start -->
    <div class=""page-title-container"">
        <div class=""row"">
            <!-- Title Start -->
            <div class=""col-auto mb-3 mb-md-0 me-auto"">
                <div class=""w-auto sw-md-30"">
                    <a href=""#"" class=""muted-link pb-1 d-inline-block breadcrumb-back"">
                        <i data-cs-icon=""chevron-left"" data-cs-size=""13""></i>
                        <span class=""text-small align-middle"">Home</span>
                    </a>
                    <h1 class=""mb-0 pb-0 display-4"" id=""title"">Order List</h1>
                </div>
            </div>
            <!-- Title End -->
            <!-- Top Buttons Start -->
            <div class=""col-3 d-flex align-items-end justify-content-end"">
                <!-- Check Button Start -->
                <div class=""btn-group ms-1 check-all-container"">
                    <div class=""btn btn-outline-primary btn-cu");
            WriteLiteral(@"stom-control p-0 ps-3 pe-2"" data-target=""#checkboxTable"">
                        <span class=""form-check float-end"">
                            <input type=""checkbox"" class=""form-check-input"" id=""checkAll"" />
                        </span>
                    </div>
                    <button type=""button""
                            class=""btn btn-outline-primary dropdown-toggle dropdown-toggle-split""
                            data-bs-offset=""0,3""
                            data-bs-toggle=""dropdown""
                            aria-haspopup=""true""
                            aria-expanded=""false""></button>
                    <div class=""dropdown-menu dropdown-menu-end"">
                        <a class=""dropdown-item"" href=""#"">
                            <span class=""align-middle d-inline-block"">Status</span>
                        </a>
                        <a class=""dropdown-item"" href=""#"">
                            <span class=""align-middle d-inline-block"">Move</span>
      ");
            WriteLiteral(@"                  </a>
                        <a class=""dropdown-item"" href=""#"">
                            <span class=""align-middle d-inline-block"">Delete</span>
                        </a>
                    </div>
                </div>
                <!-- Check Button End -->
            </div>
            <!-- Top Buttons End -->
        </div>
    </div>
    <!-- Title and Top Buttons End -->
    <!-- Controls Start -->
    <div class=""row mb-2"">
        <!-- Search Start -->
        <div class=""col-sm-12 col-md-5 col-lg-3 col-xxl-2 mb-1"">
            <div class=""d-inline-block float-md-start me-1 mb-1 search-input-container w-100 shadow bg-foreground"">
                <input class=""form-control"" placeholder=""Search"" />
                <span class=""search-magnifier-icon"">
                    <i data-cs-icon=""search""></i>
                </span>
                <span class=""search-delete-icon d-none"">
                    <i data-cs-icon=""close""></i>
                </span>
 ");
            WriteLiteral(@"           </div>
        </div>
        <!-- Search End -->

        <div class=""col-sm-12 col-md-7 col-lg-9 col-xxl-10 text-end mb-1"">
            <div class=""d-inline-block"">
                <!-- Print Button Start -->
                <button class=""btn btn-icon btn-icon-only btn-foreground-alternate shadow""
                        data-bs-toggle=""tooltip""
                        data-bs-placement=""top""
                        data-bs-delay=""0""
                        title=""Print""
                        type=""button"">
                    <i data-cs-icon=""print""></i>
                </button>
                <!-- Print Button End -->
                <!-- Export Dropdown Start -->
                <div class=""d-inline-block"">
                    <button class=""btn p-0"" data-bs-toggle=""dropdown"" type=""button"" data-bs-offset=""0,3"">
                        <span class=""btn btn-icon btn-icon-only btn-foreground-alternate shadow dropdown""
                              data-bs-delay=""0""
     ");
            WriteLiteral(@"                         data-bs-placement=""top""
                              data-bs-toggle=""tooltip""
                              title=""Export"">
                            <i data-cs-icon=""download""></i>
                        </span>
                    </button>
                    <div class=""dropdown-menu shadow dropdown-menu-end"">
                        <button class=""dropdown-item export-copy"" type=""button"">Copy</button>
                        <button class=""dropdown-item export-excel"" type=""button"">Excel</button>
                        <button class=""dropdown-item export-cvs"" type=""button"">Cvs</button>
                    </div>
                </div>
                <!-- Export Dropdown End -->
                <!-- Length Start -->
                <div class=""dropdown-as-select d-inline-block"" data-childSelector=""span"">
                    <button class=""btn p-0 shadow"" type=""button"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" data-bs-offset=""0,3"">
  ");
            WriteLiteral(@"                      <span class=""btn btn-foreground-alternate dropdown-toggle""
                              data-bs-toggle=""tooltip""
                              data-bs-placement=""top""
                              data-bs-delay=""0""
                              title=""Item Count"">
                            10 Items
                        </span>
                    </button>
                    <div class=""dropdown-menu shadow dropdown-menu-end"">
                        <a class=""dropdown-item"" href=""#"">5 Items</a>
                        <a class=""dropdown-item active"" href=""#"">10 Items</a>
                        <a class=""dropdown-item"" href=""#"">20 Items</a>
                    </div>
                </div>
                <!-- Length End -->
            </div>
        </div>
    </div>
    <!-- Controls End -->
    <!-- Order List Start -->
    <div class=""row"">
        <div class=""col-12 mb-5"">
            <div class=""card mb-2 bg-transparent no-shadow d-none d-md-block"">
");
            WriteLiteral(@"                <div class=""card-body pt-0 pb-0 sh-3"">
                    <div class=""row g-0 h-100 align-content-center"">
                        <div class=""col-12 col-md-1 d-flex align-items-center mb-2 mb-md-0 text-muted text-small"">ID</div>
                        <div class=""col-6 col-md-1 d-flex align-items-center text-alternate text-medium text-muted text-small"">NAME</div>
                        <div class=""col-6 col-md-1 d-flex align-items-center text-alternate text-medium text-muted text-small"">PRICE</div>
                        <div class=""col-6 col-md-1 d-flex align-items-center text-alternate text-medium text-muted text-small"">RAITING</div>
                        <div class=""col-6 col-md-1 d-flex align-items-center text-alternate text-medium text-muted text-small"">STOCK COUNT</div>
                        <div class=""col-6 col-md-1 d-flex align-items-center text-alternate text-medium text-muted text-small"">DESCRIPTION</div>
                        <div class=""col-6 col-md-1 d-flex ali");
            WriteLiteral(@"gn-items-center text-alternate text-medium text-muted text-small"">CATEGORY</div>
                        <div class=""col-6 col-md-1 d-flex align-items-center text-alternate text-medium text-muted text-small"">STATUS</div>
                    </div>
                </div>
            </div>
            <div>
");
#nullable restore
#line 153 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card mb-2"">
                        <div class=""card-body pt-0 pb-0 sh-21 sh-md-8"">
                            <div class=""row g-0 h-100 align-content-center"">
                                <div class=""col-11 col-md-1 d-flex flex-column justify-content-center mb-2 mb-md-0 h-md-100 position-relative"">
                                    <div class=""text-muted text-small d-md-none"">Id</div>
                                    <a href=""Orders.Detail.html"" class=""text-truncate h-100 d-flex align-items-center"">");
#nullable restore
#line 160 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </div>
                                <div class=""col-6 col-md-1 d-flex flex-column justify-content-center mb-2 mb-md-0"">
                                    <div class=""text-muted text-small d-md-none"">Name</div>
                                    <div class=""text-alternate"">");
#nullable restore
#line 164 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-6 col-md-1 d-flex flex-column justify-content-center mb-2 mb-md-0"">
                                    <div class=""text-muted text-small d-md-none"">Price</div>
                                    <div class=""text-alternate"">
                                        <span>
                                            <span class=""text-small"">$</span>
                                            ");
#nullable restore
#line 171 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </span>
                                    </div>
                                </div>
                                <div class=""col-6 col-md-1 d-flex flex-column justify-content-center mb-2 mb-md-0"">
                                    <div class=""text-muted text-small d-md-none"">Raiting</div>
                                    <div class=""text-alternate"">");
#nullable restore
#line 177 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                                           Write(item.Raiting);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-6 col-md-1 d-flex flex-column justify-content-center mb-2 mb-md-0"">
                                    <div class=""text-muted text-small d-md-none"">Stock Count</div>
                                    <div class=""text-alternate"">");
#nullable restore
#line 181 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                                           Write(item.StockCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-6 col-md-1 d-flex flex-column justify-content-center mb-2 mb-md-0"">
                                    <div class=""text-muted text-small d-md-none"">Description</div>
                                    <div class=""text-alternate"">");
#nullable restore
#line 185 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-6 col-md-1 d-flex flex-column justify-content-center mb-2 mb-md-0"">
                                    <div class=""text-muted text-small d-md-none"">Category</div>
                                    <div class=""text-alternate"">");
#nullable restore
#line 189 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                                           Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-6 col-md-1 d-flex flex-column justify-content-center mb-2 mb-md-0"">
                                    <div class=""text-muted text-small d-md-none"">Status</div>
                                    <div class=""text-alternate"">
                                        ");
#nullable restore
#line 194 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                    Write(item.IsDeleted==false?Html.Raw("<span class='badge rounded-pill bg-outline-success'>Görsənir</span>"): Html.Raw("<span class='badge rounded-pill bg-outline-danger'>Silinib</span>"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-1 d-flex flex-row mb-2 mb-lg-0 align-items-center order-2 order-lg-last justify-content-lg-center"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b369af8e074c8cc246da909c58603f0067ab89c723418", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 198 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <span type=\"button\" class=\"btn btn-outline-danger mx-lg-1\" data-bs-toggle=\"modal\" data-bs-target=\"#deleteModal\" data-id=\"");
#nullable restore
#line 199 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                                                                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 204 "C:\Users\ULVI\Desktop\AP203 Backend\Geco\Geco\Areas\Manage\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <!-- Order List End -->
    <!-- Pagination Start -->
    <div class=""d-flex justify-content-center"">
        <nav>
            <ul class=""pagination"">
                <li class=""page-item disabled"">
                    <a class=""page-link shadow"" href=""#"" tabindex=""-1"" aria-disabled=""true"">
                        <i data-cs-icon=""chevron-left""></i>
                    </a>
                </li>
                <li class=""page-item active""><a class=""page-link shadow"" href=""#"">1</a></li>
                <li class=""page-item""><a class=""page-link shadow"" href=""#"">2</a></li>
                <li class=""page-item""><a class=""page-link shadow"" href=""#"">3</a></li>
                <li class=""page-item"">
                    <a class=""page-link"" href=""#"">
                        <i data-cs-icon=""chevron-right""></i>
                    </a>
                </li>
            </ul>
        </nav>
    </div>
    <!-- Pagination End -->
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b369af8e074c8cc246da909c58603f0067ab89c727752", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b369af8e074c8cc246da909c58603f0067ab89c728852", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b369af8e074c8cc246da909c58603f0067ab89c729952", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b369af8e074c8cc246da909c58603f0067ab89c731052", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        $(\"span[type=\'button\']\").click(function () {\r\n            $(\"#deleteModal form\").attr(\"action\", \"/Manage/Slider/Delete/\" + $(this).attr(\"data-id\"))\r\n        })\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
