"use strict";(self.webpackChunkdocusaurus=self.webpackChunkdocusaurus||[]).push([[305],{8520:(e,i,n)=>{n.r(i),n.d(i,{assets:()=>c,contentTitle:()=>r,default:()=>u,frontMatter:()=>s,metadata:()=>a,toc:()=>l});var t=n(4848),o=n(8453);const s={title:"GitHub Package"},r="GitHub Package",a={id:"mp-packages/github",title:"GitHub Package",description:"The GitHub package offered by Modular Pipelines, in conjunction with the implemented OctoKit client library, facilitates a streamlined approach to interacting with remote GitHub repositories.",source:"@site/docs/mp-packages/github.md",sourceDirName:"mp-packages",slug:"/mp-packages/github",permalink:"/ModularPipelines/docs/mp-packages/github",draft:!1,unlisted:!1,tags:[],version:"current",frontMatter:{title:"GitHub Package"},sidebar:"tutorialSidebar",previous:{title:"Additional Packages",permalink:"/ModularPipelines/docs/category/additional-packages"},next:{title:"Examples",permalink:"/ModularPipelines/docs/category/examples"}},c={},l=[{value:"GitHub Client",id:"github-client",level:2},{value:"RepositoryInfo",id:"repositoryinfo",level:2},{value:"Client Auth",id:"client-auth",level:2},{value:"Using GitHubOptions Record",id:"using-githuboptions-record",level:3}];function d(e){const i={code:"code",h1:"h1",h2:"h2",h3:"h3",li:"li",p:"p",pre:"pre",strong:"strong",ul:"ul",...(0,o.R)(),...e.components};return(0,t.jsxs)(t.Fragment,{children:[(0,t.jsx)(i.h1,{id:"github-package",children:"GitHub Package"}),"\n",(0,t.jsxs)(i.p,{children:["The ",(0,t.jsx)(i.strong,{children:"GitHub package"})," offered by ",(0,t.jsx)(i.strong,{children:"Modular Pipelines"}),", in conjunction with the implemented ",(0,t.jsx)(i.strong,{children:"OctoKit client library"}),", facilitates a streamlined approach to interacting with remote GitHub repositories."]}),"\n",(0,t.jsx)(i.p,{children:"By leveraging this package, developers can more efficiently integrate their pipelines with GitHub, allowing for a smoother workflow and interaction with the platform's extensive API. The convenience afforded by this tool makes it an indispensable asset for anyone looking to automate tasks, synchronize data, or manage repositories programmatically on GitHub within their build pipelines."}),"\n",(0,t.jsx)(i.h2,{id:"github-client",children:"GitHub Client"}),"\n",(0,t.jsxs)(i.p,{children:["Using ",(0,t.jsx)(i.strong,{children:"Octokit"})," in Modular Pipelines is pretty straightforward. Simply reference the ",(0,t.jsx)(i.code,{children:"ModularPipelines.GitHub"})," package, and then, in your module, access the OctoKit client using ",(0,t.jsx)(i.code,{children:"GitHub().Client"})," property as (an example):"]}),"\n",(0,t.jsx)(i.pre,{children:(0,t.jsx)(i.code,{className:"language-cs",children:'public class GitHubModule : Module\n{\n    protected override async Task ExecuteAsync(\n        IPipelineContext context, \n        CancellationToken cancellationToken)\n    {\n        var info = context.GitHub().RepositoryInfo;\n        var user = await context.GitHub().Client.User.Get(info.Owner);\n        \n        context.Logger.LogInformation("User location: {Location}", user.Location);\n\n        return Task.CompletedTask;\n    }\n}\n'})}),"\n",(0,t.jsx)(i.h2,{id:"repositoryinfo",children:"RepositoryInfo"}),"\n",(0,t.jsxs)(i.p,{children:["Various GitHub APIs need certain repository data to be passed to make them work. For general developer ergonomics and easy access, as an additional convenience to work with GitHub APIs, Modular Pipelines' ",(0,t.jsx)(i.code,{children:"GitHub()"})," provides the ",(0,t.jsx)(i.code,{children:"RepositoryInfo"})," property that holds various basic data for easy interaction with OctoKit."]}),"\n",(0,t.jsxs)(i.p,{children:["This feature is really important because many services in the GitHub API need details such as the ",(0,t.jsx)(i.strong,{children:"repository owner"})," and ",(0,t.jsx)(i.strong,{children:"the name of the repository."})," For example:"]}),"\n",(0,t.jsx)(i.pre,{children:(0,t.jsx)(i.code,{className:"language-cs",children:"// Let's delete GitHub release with Id 12\nvar info = context.GitHub().RepositoryInfo;\nvar owner = info.Owner;\nvar repo = info.RepositoryName;\n\nawait context.GitHub().Client.Repository.Release.Delete(owner, repo, 12);\n"})}),"\n",(0,t.jsx)(i.h2,{id:"client-auth",children:"Client Auth"}),"\n",(0,t.jsxs)(i.p,{children:["Modular Pipelines' ",(0,t.jsx)(i.code,{children:"GitHub()"})," automatically authenticates OctoKit client when:"]}),"\n",(0,t.jsxs)(i.ul,{children:["\n",(0,t.jsxs)(i.li,{children:["Environment variable named ",(0,t.jsx)(i.code,{children:"GITHUB_TOKEN"})," is set (which is automatically provided by GitHub when running the pipeline in the GitHub workflow)"]}),"\n",(0,t.jsxs)(i.li,{children:["By using property ",(0,t.jsx)(i.code,{children:"AccessToken"})," in",(0,t.jsx)(i.code,{children:"GitHubOptions"})," record provided by the Modular Pipelines"]}),"\n"]}),"\n",(0,t.jsx)(i.h3,{id:"using-githuboptions-record",children:"Using GitHubOptions Record"}),"\n",(0,t.jsxs)(i.p,{children:["Configuring OctoKit auth using ",(0,t.jsx)(i.code,{children:"GitHubOptions"})," is straightforward as it follows standard .NET practices for working with ",(0,t.jsx)(i.code,{children:"IConfiguration"})," and ",(0,t.jsx)(i.code,{children:"IOptions<T>"}),". When configuring your pipeline, use the usual practices for working with configuration to configure OctoKit auth:"]}),"\n",(0,t.jsx)(i.pre,{children:(0,t.jsx)(i.code,{className:"language-cs",children:'await PipelineHostBuilder.Create()\n    .ConfigureAppConfiguration((_, builder) =>\n    {\n        builder.AddJsonFile("appsettings.json")\n            .AddUserSecrets<Program>()\n            .AddEnvironmentVariables();\n    })\n    .ConfigureServices((context, collection) =>\n    {\n        // Registers a section from the configuration file with GitHubOptions\n        collection.Configure<GitHubOptions>(context.Configuration.GetSection("ModularPipelines:Secrets:GitHub"));\n    })    \n    .ExecutePipelineAsync();\n'})}),"\n",(0,t.jsxs)(i.p,{children:["where ",(0,t.jsx)(i.code,{children:"appsettings.json"})," is constructed as follows:"]}),"\n",(0,t.jsx)(i.pre,{children:(0,t.jsx)(i.code,{className:"language-json",children:'{\n  "ModularPipelines": {\n    "Secrets": {\n      "AccessToken": "your github access token"\n    }\n  }\n}\n'})}),"\n",(0,t.jsx)(i.p,{children:"Once configured, Modular Pipelines will handle authentication and authorization automatically by utilizing the provided access token and will deliver a GitHub client that is ready for immediate use."}),"\n",(0,t.jsxs)(i.p,{children:[(0,t.jsx)(i.strong,{children:"Important Note:"})," This is just an example; ",(0,t.jsx)(i.strong,{children:"do not store any confidential data in appsettings.json, .env files, and similar."})," Use secret storage, key-vault services, etc., for storing sensitive data, and then use the described configuration practices as shown in the example above."]})]})}function u(e={}){const{wrapper:i}={...(0,o.R)(),...e.components};return i?(0,t.jsx)(i,{...e,children:(0,t.jsx)(d,{...e})}):d(e)}},8453:(e,i,n)=>{n.d(i,{R:()=>r,x:()=>a});var t=n(6540);const o={},s=t.createContext(o);function r(e){const i=t.useContext(s);return t.useMemo((function(){return"function"==typeof e?e(i):{...i,...e}}),[i,e])}function a(e){let i;return i=e.disableParentContext?"function"==typeof e.components?e.components(o):e.components||o:r(e.components),t.createElement(s.Provider,{value:i},e.children)}}}]);