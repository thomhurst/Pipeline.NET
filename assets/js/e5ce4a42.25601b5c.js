"use strict";(self.webpackChunkdocusaurus=self.webpackChunkdocusaurus||[]).push([[610],{8570:(e,o,n)=>{n.r(o),n.d(o,{assets:()=>d,contentTitle:()=>r,default:()=>m,frontMatter:()=>a,metadata:()=>c,toc:()=>l});var t=n(4848),s=n(8453);const a={title:"Custom Commands"},r="Custom Commands",c={id:"how-to/custom-commands",title:"Custom Commands",description:"Many common CLI tools, such as npm, yarn, dotnet, docker, kubectl, have all had strong objects created to wrap around their CLI commands.",source:"@site/docs/how-to/custom-commands.md",sourceDirName:"how-to",slug:"/how-to/custom-commands",permalink:"/ModularPipelines/docs/how-to/custom-commands",draft:!1,unlisted:!1,tags:[],version:"current",frontMatter:{title:"Custom Commands"},sidebar:"tutorialSidebar",previous:{title:"Console Progress",permalink:"/ModularPipelines/docs/how-to/console-progress"},next:{title:"Defining Modules",permalink:"/ModularPipelines/docs/how-to/defining-modules"}},d={},l=[{value:"Example",id:"example",level:2}];function i(e){const o={code:"code",h1:"h1",h2:"h2",header:"header",p:"p",pre:"pre",...(0,s.R)(),...e.components};return(0,t.jsxs)(t.Fragment,{children:[(0,t.jsx)(o.header,{children:(0,t.jsx)(o.h1,{id:"custom-commands",children:"Custom Commands"})}),"\n",(0,t.jsx)(o.p,{children:"Many common CLI tools, such as npm, yarn, dotnet, docker, kubectl, have all had strong objects created to wrap around their CLI commands."}),"\n",(0,t.jsxs)(o.p,{children:["If you want to run a command that isn't currently supported by strong objects, you can still run commands directly through the ",(0,t.jsx)(o.code,{children:"ICommand"})," interface available on the ",(0,t.jsx)(o.code,{children:"context"})," object within your modules."]}),"\n",(0,t.jsx)(o.p,{children:"Every argument should be passed as a separate string in a collection. This allows proper formatting if there's things like spaces or quotes."}),"\n",(0,t.jsx)(o.h2,{id:"example",children:"Example"}),"\n",(0,t.jsx)(o.pre,{children:(0,t.jsx)(o.code,{className:"language-csharp",children:'await context.Command.ExecuteCommandLineTool(new CommandLineToolOptions("dotnet")\n        {\n            Arguments = new[] { "tool", "install", "--global", "dotnet-coverage" },\n        }, cancellationToken);\n'})}),"\n",(0,t.jsx)(o.p,{children:"This is the equivalent to running:"}),"\n",(0,t.jsx)(o.p,{children:(0,t.jsx)(o.code,{children:"dotnet tool install --global dotnet-coverage"})})]})}function m(e={}){const{wrapper:o}={...(0,s.R)(),...e.components};return o?(0,t.jsx)(o,{...e,children:(0,t.jsx)(i,{...e})}):i(e)}},8453:(e,o,n)=>{n.d(o,{R:()=>r,x:()=>c});var t=n(6540);const s={},a=t.createContext(s);function r(e){const o=t.useContext(a);return t.useMemo((function(){return"function"==typeof e?e(o):{...o,...e}}),[o,e])}function c(e){let o;return o=e.disableParentContext?"function"==typeof e.components?e.components(s):e.components||s:r(e.components),t.createElement(a.Provider,{value:o},e.children)}}}]);