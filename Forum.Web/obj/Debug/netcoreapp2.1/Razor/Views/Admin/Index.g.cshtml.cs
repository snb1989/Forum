#pragma checksum "E:\Forum\Forum.Web\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00504bc788091b8beb1df24dd9481ec688198874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "E:\Forum\Forum.Web\Views\_ViewImports.cshtml"
using Forum.Web;

#line default
#line hidden
#line 2 "E:\Forum\Forum.Web\Views\_ViewImports.cshtml"
using Forum.Web.Models;

#line default
#line hidden
#line 4 "E:\Forum\Forum.Web\Views\Admin\Index.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00504bc788091b8beb1df24dd9481ec688198874", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09ec3c6e9a0062d6fc2a8ee2d84a3a94360c7a8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/ztree/css/metroStyle/metroStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Forum\Forum.Web\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "管理员管理";
    

#line default
#line hidden
#line 4 "E:\Forum\Forum.Web\Views\Admin\Index.cshtml"
                                               
    Layout = AdminLayout.Pjax(ViewBag.httpContext);

#line default
#line hidden
            BeginContext(145, 846, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""layui-col-220"">
        <div class=""layui-nav-title"">用户管理</div>
        <ul id=""tree"" class=""ztree layui-tree-cus""></ul>
    </div>
    <div class=""right-col-body"">
        <div class=""list-wall"">
            <div class=""layui-form list-search"">
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""organizeAdd""><i class=""layui-icon""></i> 新增</button>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""organizeDel""><i class=""layui-icon""></i> 删除</button>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolToRole""><i class=""layui-icon layui-icon-template""></i> 用户分配角色</button>
            </div>
            <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
        </div>
    </div>
    ");
            EndContext();
            BeginContext(991, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93da60f526a848fe8421cc56ff705836", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1082, 6718, true);
            WriteLiteral(@"
    <script>
            layui.config({
                base: '/themes/js/modules/'
            }).use(['table', 'layer', 'jquery', 'ztree', 'common'],
                function () {
                    var table = layui.table,
                        layer = layui.layer,
                        $ = layui.jquery,
                        ztree = layui.ztree,
                        os = layui.common,
                        form = layui.form;
                    table.render({
                        elem: '#tablist',
                        headers: os.getToken(),
                        url: '/api/admin/getpages',
                        cols: [
                            [
                                { type: 'checkbox', fixed: 'left' },
                                { field: 'loginName', title: '登录账号', sort: true, fixed: 'left' },
                                { field: 'trueName', title: '真是姓名' },
                                { field: 'departmentName', title: '所属部门' },
    ");
            WriteLiteral(@"                            { field: 'sex', title: '性别' },
                                { field: 'loginDate', title: '最后登录时间' },
                                { width: 100, title: '操作', templet: '#tool' }
                            ]
                        ],
                        page: true,
                        id: 'tables'
                    });
                    var setting = {
                        async: {
                            enable: true,
                            headers: os.getToken(),
                            url: ""/api/organize/gettree""
                        },
                        callback: {
                            onClick: onClick
                        }
                    };
                    var guid = '', typeName = '', active = {
                        reload: function () {
                            table.reload('tables',
                                {
                                    page: {
                        ");
            WriteLiteral(@"                curr: 1
                                    },
                                    where: {
                                        key: guid
                                    }
                                });
                        },
                        //为用户分配角色
                        toolToRole: function () {
                            var checkStatus = table.checkStatus('tables')
                                , data = checkStatus.data;
                            if (data.length === 0) {
                                os.error(""请选择要分配的用户~"");
                                return;
                            }
                            var str = '', strCount = 0,adminName='';
                            $.each(data, function (i, item) {
                                str = item.guid;
                                adminName = item.loginName;
                                strCount++;
                            });
                            if (");
            WriteLiteral(@"strCount > 1) {
                                os.warning('每次只能选址一个用户~');
                                return;
                            }
                            os.Open('为用户' + adminName+'分配角色', '/fytadmin/sys/admintorole?roid='+str, '750px', '450px');
                        },
                        organizeAdd: function () {
                            os.Open('添加用户', '/fytadmin/sys/adminmodify', '750px', '400px', function () {
                                active.reload();
                                var tree = $.fn.zTree.getZTreeObj(""tree"");
                                tree.reAsyncChildNodes(null, ""refresh"");
                            });
                        },
                        organizeDel: function () {
                            var checkStatus = table.checkStatus('tables')
                                , data = checkStatus.data;
                            if (data.length === 0) {
                                os.error(""请选择要删除的项目~"");
         ");
            WriteLiteral(@"                       return;
                            }
                            var str = '';
                            $.each(data, function (i, item) {
                                str += item.guid + "","";
                            });
                            layer.confirm('确定要执行批量删除吗？', function (index) {
                                layer.close(index);
                                var loadindex = layer.load(1, {
                                    shade: [0.1, '#000']
                                });
                                os.ajax('api/admin/delete/', { parm: str }, function (res) {
                                    layer.close(loadindex);
                                    if (res.statusCode === 200) {
                                        active.reload();
                                        var tree = $.fn.zTree.getZTreeObj(""tree"");
                                        tree.reAsyncChildNodes(null, ""refresh"");
                             ");
            WriteLiteral(@"           os.success('删除成功！');
                                    } else {
                                        os.error(res.message);
                                    }
                                });
                            });

                        }
                    };
                    $.fn.zTree.init($(""#tree""), setting);
                    $('.list-search .layui-btn').on('click', function () {
                        var type = $(this).data('type');
                        active[type] ? active[type].call(this) : '';
                    });
                    function onClick(event, treeId, treeNode, clickFlag) {
                        guid = treeNode.guid;
                        active.reload();
                    }
                    //监听工具条
                    table.on('tool(tool)', function (obj) {
                        var data = obj.data;
                        if (obj.event === 'edit') {
                            os.Open('编辑用户', '/fytadmin");
            WriteLiteral(@"/sys/adminmodify/?guid=' + data.guid, '750px', '400px', function () {
                                var tree = $.fn.zTree.getZTreeObj(""tree"");
                                tree.reAsyncChildNodes(null, ""refresh"");
                                active.reload();
                            })
                        }
                    });
                });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
    </script>

</div>


");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
