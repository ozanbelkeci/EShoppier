#pragma checksum "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fddccdbb72e111b2310ff4f4a4a7cf0e96b1c508580866c8cbec5d3d98059b87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\_ViewImports.cshtml"
using EShopperAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\_ViewImports.cshtml"
using EShopperAdminPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fddccdbb72e111b2310ff4f4a4a7cf0e96b1c508580866c8cbec5d3d98059b87", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"435556858140ede28e8b73e784e2f51f264a2fb30cff7954836e76201991f7c9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EShopperAdminPanel.Models.ProductModel>>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .toggler-wrapper {
        display: block;
        width: 45px;
        height: 25px;
        cursor: pointer;
        position: relative;
    }

        .toggler-wrapper input[type=""checkbox""] {
            display: none;
        }

            .toggler-wrapper input[type=""checkbox""]:checked + .toggler-slider {
                background-color: #44cc66;
            }

        .toggler-wrapper .toggler-slider {
            background-color: #ccc;
            position: absolute;
            border-radius: 100px;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            -webkit-transition: all 300ms ease;
            transition: all 300ms ease;
        }

        .toggler-wrapper .toggler-knob {
            position: absolute;
            -webkit-transition: all 300ms ease;
            transition: all 300ms ease;
        }

    .toggler-wrapper.style-1 input[type=""checkbox""]:checked + .toggler-slider .toggler-knob {
");
            WriteLiteral(@"        left: calc(100% - 19px - 3px);
    }

    .toggler-wrapper.style-1 .toggler-knob {
        width: calc(25px - 6px);
        height: calc(25px - 6px);
        border-radius: 50%;
        left: 3px;
        top: 3px;
        background-color: #fff;
    }
</style>

<h2>Ürünler</h2>
<br />
<button type=""button"" class=""btn btn-success"" data-bs-toggle=""modal"" onclick=""getCategories()"" data-bs-target=""#createModal"">Yeni Ürün Ekle</button>
<table class=""table table-hover mt-3"">
    <thead>
        <tr>
            <th class=""d-none"">Id</th>
            <th>Ürün Adı</th>
            <th>Kategori</th>
            <th>Satış Durumu</th>
            <th>Fiyat</th>
            <th>Stok Adedi</th>
        </tr>
    </thead>
    <tbody id=""productTableBody"" class=""table-border-bottom-0"">
");
#nullable restore
#line 69 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"d-none\">");
#nullable restore
#line 72 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 73 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 74 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 75 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
               Write(item.IsApproved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 76 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 77 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
               Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                <td>
                    <div class=""dropdown"">
                        <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                            <i class=""bx bx-dots-vertical-rounded""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2603, "\"", 2637, 3);
            WriteAttributeValue("", 2613, "getProductById(", 2613, 15, true);
#nullable restore
#line 84 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
WriteAttributeValue("", 2628, item.Id, 2628, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2636, ")", 2636, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#updateModal\" class=\"dropdown-item\"><i class=\"bx bx-edit-alt me-1\"></i> Edit</a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2790, "\"", 2823, 3);
            WriteAttributeValue("", 2800, "deleteProduct(", 2800, 14, true);
#nullable restore
#line 85 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
WriteAttributeValue("", 2814, item.Id, 2814, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2822, ")", 2822, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\"><i class=\"bx bx-trash me-1\"></i> Delete</a>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 90 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<!-- Modal -->
<div class=""modal fade"" id=""updateModal"" tabindex=""-1"" aria-labelledby=""updateModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""updateModalLabel"">Kategori</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fddccdbb72e111b2310ff4f4a4a7cf0e96b1c508580866c8cbec5d3d98059b879956", async() => {
                WriteLiteral(@"
                    <div class=""mb-3 d-none"">
                        <label for=""recipient-name"" class=""col-form-label"">ID:</label>
                        <input type=""text"" class=""form-control"" id=""id"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Kategori Adı:</label>
                        <input type=""text"" class=""form-control"" id=""upProductName"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""message-text"" class=""col-form-label"">Açıklama:</label>
                        <textarea class=""form-control"" id=""upDesc""></textarea>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Kapat</button>
                <button onclick=""updateProduct()"" type=""button"" class=""btn btn-primary"">Güncelle</button>
            </div>
        </div>
    </div>
</div>



<div class=""modal"" id=""createModal"" tabindex=""-1"" aria-labelledby=""createModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""createModalLabel"">Ürün</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fddccdbb72e111b2310ff4f4a4a7cf0e96b1c508580866c8cbec5d3d98059b8712836", async() => {
                WriteLiteral(@"
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Kategori Adı</label>
                        <input type=""text"" class=""form-control"" id=""productName"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""message-text"" class=""col-form-label"">Açıklama</label>
                        <textarea class=""form-control"" id=""desc""></textarea>
                    </div>
                    <div class=""input-group mb-3"">
                        <label for=""message-text"" class=""col-form-label"">Fiyat</label>
                        <div class=""input-group mb-3"">
                            <span class=""input-group-text"">₺</span>
                            <input type=""number"" id=""price"" class=""form-control"" aria-label=""Amount (to the nearest dollar)"">
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label for=""recipient");
                WriteLiteral(@"-name"" class=""col-form-label"">Stok Adedi</label>
                        <input type=""number"" class=""form-control"" id=""stock"" oninput=""this.value = Math.round(this.value);"">
                    </div>
                    <div class=""input-group mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Satış Durumu</label>
                        <label class=""m-1 ms-3 toggler-wrapper style-1"">
                            <input id=""isApproved"" type=""checkbox"">
                            <div class=""toggler-slider"">
                                <div class=""toggler-knob""></div>
                            </div>
                        </label>
                    </div>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Fotoğraf</label>
                        <input type=""file"" class=""form-control"" id=""productPhoto"" aria-describedby=""inputGroupFileAddon03"" aria-label=""Upload"" accept=""image/*"">
           ");
                WriteLiteral(@"         </div>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Kategori Adı</label>
                        <select class=""form-select"" id=""category"">
                            
                        </select>
                    </div>

                    

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Kapat</button>
                <button onclick=""createProduct()"" type=""button"" class=""btn btn-primary"">Ekle</button>
            </div>
        </div>
    </div>
</div>


<script>

    function createProduct() {
        debugger;
        var doc = $(""#productPhoto"");
        var productName = $(""#productName"").val();
        var desc = $(""#desc"").val();
        var price = parseFloat($(""#price"").val());
        var stock = parseInt($(""#stock"").val());
        var isApproved = $('#isApproved').is("":checked"");
        var productPhoto = doc[0].files[0];
        var category = parseInt($(""#category"").val());

        var formData = new FormData();
        formData.append(""_name"", productName);
        formData.append(""_desc"", desc);
        formData.append(""_price"", price);
        formData.append(""_stock"", stock);
        formData.append(");
            WriteLiteral("\"_isApproved\", isApproved);\r\n        formData.append(\"_photo\", productPhoto);\r\n        formData.append(\"_categoryId\", category);\r\n\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 212 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
             Write(Url.Action("CreateProduct", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            data: formData,
            contentType: false,
            processData: false,
            success: function (data) {
                if (data) {
                    $(function () {
                        $('#createModal').modal('toggle');
                    });
                    Swal.fire({
                        title: ""Başarılı!"",
                        text: ""Ürün başarıyla eklendi."",
                        icon: ""success""
                    });
                    //updateTable();
                }
                else {
                    $(function () {
                        $('#createModal').modal('toggle');
                    });
                    Swal.fire({
                        title: ""Hata!"",
                        text: ""Bir şeyler ters gitti lütfen tekrar deneyiniz!"",
                        icon: ""error""
                    });

                    return;
                }
  ");
            WriteLiteral("          }\r\n        });\r\n    }\r\n\r\n    function getCategories() {\r\n\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 249 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
             Write(Url.Action("GetCategories", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            success: function (data) {
                if (data) {
                    $(""#category"").empty();
                    var trHtml = """";
                    for (var item of data) {
                        trHtml += '<option value=""'+ item.id +'"">'+ item.name +'</option>';
                    }
                    $(""#category"").append(trHtml);
                }
                else {
                    
                    Swal.fire({
                        title: ""Hata!"",
                        text: ""Bir şeyler ters gitti lütfen tekrar deneyiniz!"",
                        icon: ""error""
                    });

                    return;
                }
            }
        });
    }

    function updateTable() {
        $.ajax({
            url: '");
#nullable restore
#line 277 "C:\Users\obelkeci\Desktop\Projects\EShoppier\EShopper\EShopperAdminPanel\Views\Product\Index.cshtml"
             Write(Url.Action("UpdateTable", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            success: function (data) {
                if (data) {
                    $(""#productTableBody"").empty();
                    var trHtml = """";
                    for (var item of data) {
                        trHtml += '<tr>';
                        trHtml += '    <td class=""d-none""> ' + item.Id + '</td>';
                        trHtml += '        <td> ' + item.name + '</td>'
                        trHtml += '        <td> ' + item.category.name + '</td>'
                        trHtml += '        <td> ' + item.isApproved + '</td>'
                        trHtml += '        <td> ' + item.price + '</td>'
                        trHtml += '        <td> ' + item.stock + '</td>'
                        trHtml += '        <div class=""dropdown"" >'
                        trHtml += '            <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">'
                        trHtml += '   ");
            WriteLiteral(@"             <i class=""bx bx-dots-vertical-rounded"" > </i>'
                        trHtml += '            </button>'
                        trHtml += '            <div class=""dropdown-menu"">'
                        trHtml += '                 <a onclick=""getProductById(' + item.id + ')"" data-bs-toggle=""modal"" data-bs-target=""#updateModal"" class=""dropdown-item"" > <i class=""bx bx-edit-alt me-1""> </i>Edit</a>'
                        trHtml += '                 <a onclick=""deleteProduct(' + item.id + ')"" class=""dropdown-item"" > <i class=""bx bx-trash me-1"" > </i> Delete</a>'
                        trHtml += '            </div>'
                        trHtml += '        </div>'
                        trHtml += '     </td>'
                        trHtml += '</tr>';
                    }
                    $(""#productTableBody"").append(trHtml);
                }
                else {
                    Swal.fire({
                        title: ""Hata!"",
                        text: ""Tablo y");
            WriteLiteral("üklenirken bir şeyler ters gitti lütfen tekrar deneyiniz!\",\r\n                        icon: \"error\"\r\n                    });\r\n\r\n                    return;\r\n                }\r\n            }\r\n        });\r\n    }\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EShopperAdminPanel.Models.ProductModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
