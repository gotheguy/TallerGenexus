/*!   GeneXus C# 16_0_7-138086 on 2/25/2020 21:45:24.80
*/
gx.evt.autoSkip=!1;gx.define("pais",!1,function(){var n,t;this.ServerClass="pais";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7PaisId=gx.fn.getIntegerValue("vPAISID",",");this.Gx_BScreen=gx.fn.getIntegerValue("vGXBSCREEN",",");this.A40000PaisBandera_GXI=gx.fn.getControlValue("PAISBANDERA_GXI");this.AV13Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV9TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Paisid=function(){return this.validCliEvt("Valid_Paisid",0,function(){try{var n=gx.util.balloon.getNew("PAISID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Paisnombre=function(){return this.validSrvEvt("Valid_Paisnombre",0).then(function(n){return n}.closure(this))};this.Valid_Ciudadid=function(){var n=gx.fn.currentGridRowImpl(53);return this.validCliEvt("Valid_Ciudadid",53,function(){try{if(gx.fn.currentGridRowImpl(53)===0)return!0;var n=gx.util.balloon.getNew("CIUDADID",gx.fn.currentGridRowImpl(53));this.AnyError=0;this.sMode2=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(2,53);this.standaloneModal012();this.standaloneNotModal012();gx.fn.gridDuplicateKey(54)&&(n.setError(gx.text.format(gx.getMessage("GXM_1004"),"Ciudad","","","","","","","","")),this.AnyError=gx.num.trunc(1,0))}catch(t){}try{return(this.Gx_mode=this.sMode2,n==null)?!0:n.show()}catch(t){}return!0})};this.standaloneModal012=function(){try{this.Gx_mode!="INS"?gx.fn.setCtrlProperty("CIUDADID","Enabled",0):gx.fn.setCtrlProperty("CIUDADID","Enabled",1)}catch(n){}};this.standaloneNotModal012=function(){};this.e12012_client=function(){return this.executeServerEvent("AFTER TRN",!0,arguments[0],!1,!1)};this.e13011_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14011_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,54,55,56,57,58,59,60,61,62,63,64];this.GXLastCtrlId=64;this.Gridpais_ciudadContainer=new gx.grid.grid(this,2,"Ciudad",53,"Gridpais_ciudad","Gridpais_ciudad","Gridpais_ciudadContainer",this.CmpContext,this.IsMasterPage,"pais",[4],!1,1,!1,!0,5,!1,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Gridpais_ciudadContainer;t.addSingleLineEdit(4,54,"CIUDADID","Id","","CiudadId","int",0,"px",4,4,"right",null,[],4,"CiudadId",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(5,55,"CIUDADNOMBRE","Nombre","","CiudadNombre","char",0,"px",100,80,"left",null,[],5,"CiudadNombre",!0,0,!1,!1,"Attribute",1,"");this.Gridpais_ciudadContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0,evt:"e15011_client",std:"FIRST"};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0,evt:"e16011_client",std:"PREVIOUS"};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0,evt:"e17011_client",std:"NEXT"};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0,evt:"e18011_client",std:"LAST"};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0,evt:"e19011_client",std:"SELECT"};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Paisid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridpais_ciudadContainer],fld:"PAISID",gxz:"Z1PaisId",gxold:"O1PaisId",gxvar:"A1PaisId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1PaisId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1PaisId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PAISID",gx.O.A1PaisId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1PaisId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PAISID",",")},nac:gx.falseFn};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Paisnombre,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAISNOMBRE",gxz:"Z2PaisNombre",gxold:"O2PaisNombre",gxvar:"A2PaisNombre",ucs:[],op:[39],ip:[34,39],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2PaisNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z2PaisNombre=n)},v2c:function(){gx.fn.setControlValue("PAISNOMBRE",gx.O.A2PaisNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2PaisNombre=this.val())},val:function(){return gx.fn.getControlValue("PAISNOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAISBANDERA",gxz:"Z3PaisBandera",gxold:"O3PaisBandera",gxvar:"A3PaisBandera",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3PaisBandera=n)},v2z:function(n){n!==undefined&&(gx.O.Z3PaisBandera=n)},v2c:function(){gx.fn.setMultimediaValue("PAISBANDERA",gx.O.A3PaisBandera,gx.O.A40000PaisBandera_GXI)},c2v:function(){gx.O.A40000PaisBandera_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A3PaisBandera=this.val())},val:function(){return gx.fn.getBlobValue("PAISBANDERA")},val_GXI:function(){return gx.fn.getControlValue("PAISBANDERA_GXI")},gxvar_GXI:"A40000PaisBandera_GXI",nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"CIUDADTABLE",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"TITLECIUDAD",format:0,grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[54]={id:54,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:53,gxgrid:this.Gridpais_ciudadContainer,fnc:this.Valid_Ciudadid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CIUDADID",gxz:"Z4CiudadId",gxold:"O4CiudadId",gxvar:"A4CiudadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A4CiudadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z4CiudadId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CIUDADID",n||gx.fn.currentGridRowImpl(53),gx.O.A4CiudadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A4CiudadId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("CIUDADID",n||gx.fn.currentGridRowImpl(53),",")},nac:gx.falseFn};n[55]={id:55,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:0,isacc:1,grid:53,gxgrid:this.Gridpais_ciudadContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CIUDADNOMBRE",gxz:"Z5CiudadNombre",gxold:"O5CiudadNombre",gxvar:"A5CiudadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A5CiudadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z5CiudadNombre=n)},v2c:function(n){gx.fn.setGridControlValue("CIUDADNOMBRE",n||gx.fn.currentGridRowImpl(53),gx.O.A5CiudadNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A5CiudadNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("CIUDADNOMBRE",n||gx.fn.currentGridRowImpl(53))},nac:gx.falseFn};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"BTN_ENTER",grid:0,evt:"e13011_client",std:"ENTER"};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"BTN_CANCEL",grid:0,evt:"e14011_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"BTN_DELETE",grid:0,evt:"e20011_client",std:"DELETE"};this.A1PaisId=0;this.Z1PaisId=0;this.O1PaisId=0;this.A2PaisNombre="";this.Z2PaisNombre="";this.O2PaisNombre="";this.A40000PaisBandera_GXI="";this.A3PaisBandera="";this.Z3PaisBandera="";this.O3PaisBandera="";this.Z4CiudadId=0;this.O4CiudadId=0;this.Z5CiudadNombre="";this.O5CiudadNombre="";this.A4CiudadId=0;this.A5CiudadNombre="";this.A40000PaisBandera_GXI="";this.AV13Pgmname="";this.AV9TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV7PaisId=0;this.AV10WebSession={};this.A1PaisId=0;this.Gx_BScreen=0;this.A2PaisNombre="";this.A3PaisBandera="";this.Gx_mode="";this.Events={e12012_client:["AFTER TRN",!0],e13011_client:["ENTER",!0],e14011_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7PaisId",fld:"vPAISID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0},{av:"AV7PaisId",fld:"vPAISID",pic:"ZZZ9",hsh:!0},{av:"A1PaisId",fld:"PAISID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""}],[{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0}],[]];this.EvtParms.VALID_PAISID=[[],[]];this.EvtParms.VALID_PAISNOMBRE=[[{av:"A2PaisNombre",fld:"PAISNOMBRE",pic:""},{av:"A1PaisId",fld:"PAISID",pic:"ZZZ9"}],[]];this.EvtParms.VALID_CIUDADID=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7PaisId","vPAISID",0,"int",4,0);this.setVCMap("Gx_BScreen","vGXBSCREEN",0,"int",1,0);this.setVCMap("A40000PaisBandera_GXI","PAISBANDERA_GXI",0,"svchar",2048,0);this.setVCMap("AV13Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV9TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);t.addPostingVar({rfrVar:"Gx_mode"});this.Initialize()});gx.wi(function(){gx.createParentObj(pais)})