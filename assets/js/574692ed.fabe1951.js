"use strict";(self.webpackChunkdocusaurus=self.webpackChunkdocusaurus||[]).push([[395],{5543:(e,o,t)=>{t.r(o),t.d(o,{assets:()=>d,contentTitle:()=>s,default:()=>h,frontMatter:()=>i,metadata:()=>l,toc:()=>a});var n=t(4848),r=t(8453);const i={title:"Logging",sidebar_position:8},s="Logging",l={id:"how-to/logging",title:"Logging",description:"IModuleLogger",source:"@site/docs/how-to/logging.md",sourceDirName:"how-to",slug:"/how-to/logging",permalink:"/ModularPipelines/docs/how-to/logging",draft:!1,unlisted:!1,tags:[],version:"current",sidebarPosition:8,frontMatter:{title:"Logging",sidebar_position:8},sidebar:"tutorialSidebar",previous:{title:"Skipping Modules",permalink:"/ModularPipelines/docs/how-to/skipping"},next:{title:"Always Run",permalink:"/ModularPipelines/docs/how-to/always-run"}},d={},a=[{value:"IModuleLogger",id:"imodulelogger",level:2},{value:"Secret Obfuscation",id:"secret-obfuscation",level:2},{value:"Grouped Logs",id:"grouped-logs",level:2},{value:"Interfering with Console Progress",id:"interfering-with-console-progress",level:2},{value:"Analyzers",id:"analyzers",level:2},{value:"How to access IModuleLogger",id:"how-to-access-imodulelogger",level:2},{value:"Module",id:"module",level:3},{value:"Elsewhere",id:"elsewhere",level:3}];function c(e){const o={a:"a",code:"code",h1:"h1",h2:"h2",h3:"h3",header:"header",p:"p",...(0,r.R)(),...e.components};return(0,n.jsxs)(n.Fragment,{children:[(0,n.jsx)(o.header,{children:(0,n.jsx)(o.h1,{id:"logging",children:"Logging"})}),"\n",(0,n.jsx)(o.h2,{id:"imodulelogger",children:"IModuleLogger"}),"\n",(0,n.jsxs)(o.p,{children:["When logging in your pipeline, you should always use an IModuleLogger. Do not inject in your own ILogger, and do not write to the console directly using the ",(0,n.jsx)(o.code,{children:"Console"})," class, or any other class that would write directly to the console."]}),"\n",(0,n.jsxs)(o.p,{children:["This is because the ",(0,n.jsx)(o.code,{children:"IModuleLogger"})," will perform many actions that will improve the output of your logs."]}),"\n",(0,n.jsx)(o.p,{children:"These are detailed below."}),"\n",(0,n.jsx)(o.h2,{id:"secret-obfuscation",children:"Secret Obfuscation"}),"\n",(0,n.jsxs)(o.p,{children:["If secrets have been defined (See ",(0,n.jsx)(o.a,{href:"secrets",children:"Secrets"})," for details on this), then if any of them are attempted to be written to logs via IModuleLogger, either directly, or through things like HTTP or Command logs, they will be obfuscated in the output. So for instance, if you made a HTTP call with a bearer token of 'MySuperSecretToken', when the HTTP request is logged, that bearer will show as '**********'."]}),"\n",(0,n.jsx)(o.h2,{id:"grouped-logs",children:"Grouped Logs"}),"\n",(0,n.jsx)(o.p,{children:"When writing logs through IModuleLogger, logs will be grouped by what module they're in.\nSince all modules attempt to run in parallel, if there was no log organisation, then logs would be everywhere and all jumbled up, and hard to navigate. This keeps logs together, clean, and easy to read. This is why it's very important not to write to the console directly, as that'll prevent this from working."}),"\n",(0,n.jsx)(o.h2,{id:"interfering-with-console-progress",children:"Interfering with Console Progress"}),"\n",(0,n.jsx)(o.p,{children:"If you have an interactive terminal, then a progress dialog will be displayed, and constantly updated with the progress of all your modules.\nIf you start writing to the console directly, then you'll be writing over the top of this progress dialog and messing up how it renders."}),"\n",(0,n.jsx)(o.h2,{id:"analyzers",children:"Analyzers"}),"\n",(0,n.jsxs)(o.p,{children:["If you forget the above, Modular Pipelines has analyzers built as part of its framework. It'll detect direct uses of ",(0,n.jsx)(o.code,{children:"Console"}),", or trying to inject in custom ",(0,n.jsx)(o.code,{children:"ILogger"}),"s and will result in errors, asking you to fix the issues."]}),"\n",(0,n.jsx)(o.h2,{id:"how-to-access-imodulelogger",children:"How to access IModuleLogger"}),"\n",(0,n.jsx)(o.h3,{id:"module",children:"Module"}),"\n",(0,n.jsxs)(o.p,{children:["If you're in a module, it's part of your ",(0,n.jsx)(o.code,{children:"context"})," object. Call ",(0,n.jsx)(o.code,{children:"context.Logger"}),"."]}),"\n",(0,n.jsx)(o.h3,{id:"elsewhere",children:"Elsewhere"}),"\n",(0,n.jsxs)(o.p,{children:["If you're in another class, you can inject in ",(0,n.jsx)(o.code,{children:"IModuleLoggerProvider"})," and call ",(0,n.jsx)(o.code,{children:"GetLogger"}),"."]})]})}function h(e={}){const{wrapper:o}={...(0,r.R)(),...e.components};return o?(0,n.jsx)(o,{...e,children:(0,n.jsx)(c,{...e})}):c(e)}},8453:(e,o,t)=>{t.d(o,{R:()=>s,x:()=>l});var n=t(6540);const r={},i=n.createContext(r);function s(e){const o=n.useContext(i);return n.useMemo((function(){return"function"==typeof e?e(o):{...o,...e}}),[o,e])}function l(e){let o;return o=e.disableParentContext?"function"==typeof e.components?e.components(r):e.components||r:s(e.components),n.createElement(i.Provider,{value:o},e.children)}}}]);