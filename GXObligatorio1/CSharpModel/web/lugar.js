/*!   GeneXus C# 16_0_7-138086 on 2/16/2020 21:49:11.72
*/
gx.evt.autoSkip=!1;gx.define("lugar",!1,function(){this.ServerClass="lugar";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7LugarId=gx.fn.getIntegerValue("vLUGARID",",");this.AV11Insert_PaisId=gx.fn.getIntegerValue("vINSERT_PAISID",",");this.AV12Insert_CiudadId=gx.fn.getIntegerValue("vINSERT_CIUDADID",",");this.A40000LugarFoto_GXI=gx.fn.getControlValue("LUGARFOTO_GXI");this.A40001PaisBandera_GXI=gx.fn.getControlValue("PAISBANDERA_GXI");this.AV14Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV9TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Lugarid=function(){return this.validCliEvt("Valid_Lugarid",0,function(){try{var n=gx.util.balloon.getNew("LUGARID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Paisid=function(){return this.validSrvEvt("Valid_Paisid",0).then(function(n){return n}.closure(this))};this.Valid_Ciudadid=function(){return this.validSrvEvt("Valid_Ciudadid",0).then(function(n){return n}.closure(this))};this.e12032_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e13034_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14034_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80];this.GXLastCtrlId=80;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0,evt:"e15034_client",std:"FIRST"};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0,evt:"e16034_client",std:"PREVIOUS"};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0,evt:"e17034_client",std:"NEXT"};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0,evt:"e18034_client",std:"LAST"};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0,evt:"e19034_client",std:"SELECT"};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Lugarid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LUGARID",gxz:"Z8LugarId",gxold:"O8LugarId",gxvar:"A8LugarId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A8LugarId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z8LugarId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("LUGARID",gx.O.A8LugarId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A8LugarId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("LUGARID",",")},nac:function(){return!(0==this.AV7LugarId)}};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LUGARNOMBRE",gxz:"Z9LugarNombre",gxold:"O9LugarNombre",gxvar:"A9LugarNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A9LugarNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z9LugarNombre=n)},v2c:function(){gx.fn.setControlValue("LUGARNOMBRE",gx.O.A9LugarNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A9LugarNombre=this.val())},val:function(){return gx.fn.getControlValue("LUGARNOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LUGARFOTO",gxz:"Z10LugarFoto",gxold:"O10LugarFoto",gxvar:"A10LugarFoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A10LugarFoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z10LugarFoto=n)},v2c:function(){gx.fn.setMultimediaValue("LUGARFOTO",gx.O.A10LugarFoto,gx.O.A40000LugarFoto_GXI)},c2v:function(){gx.O.A40000LugarFoto_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A10LugarFoto=this.val())},val:function(){return gx.fn.getBlobValue("LUGARFOTO")},val_GXI:function(){return gx.fn.getControlValue("LUGARFOTO_GXI")},gxvar_GXI:"A40000LugarFoto_GXI",nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Paisid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAISID",gxz:"Z1PaisId",gxold:"O1PaisId",gxvar:"A1PaisId",ucs:[],op:[59,54],ip:[59,54,49],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1PaisId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1PaisId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PAISID",gx.O.A1PaisId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1PaisId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PAISID",",")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV11Insert_PaisId)}};this.declareDomainHdlr(49,function(){});n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAISNOMBRE",gxz:"Z2PaisNombre",gxold:"O2PaisNombre",gxvar:"A2PaisNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2PaisNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z2PaisNombre=n)},v2c:function(){gx.fn.setControlValue("PAISNOMBRE",gx.O.A2PaisNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2PaisNombre=this.val())},val:function(){return gx.fn.getControlValue("PAISNOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(54,function(){});n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAISBANDERA",gxz:"Z3PaisBandera",gxold:"O3PaisBandera",gxvar:"A3PaisBandera",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3PaisBandera=n)},v2z:function(n){n!==undefined&&(gx.O.Z3PaisBandera=n)},v2c:function(){gx.fn.setMultimediaValue("PAISBANDERA",gx.O.A3PaisBandera,gx.O.A40001PaisBandera_GXI)},c2v:function(){gx.O.A40001PaisBandera_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A3PaisBandera=this.val())},val:function(){return gx.fn.getBlobValue("PAISBANDERA")},val_GXI:function(){return gx.fn.getControlValue("PAISBANDERA_GXI")},gxvar_GXI:"A40001PaisBandera_GXI",nac:gx.falseFn};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Ciudadid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CIUDADID",gxz:"Z4CiudadId",gxold:"O4CiudadId",gxvar:"A4CiudadId",ucs:[],op:[69],ip:[69,64,49],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A4CiudadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z4CiudadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CIUDADID",gx.O.A4CiudadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A4CiudadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CIUDADID",",")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV12Insert_CiudadId)}};this.declareDomainHdlr(64,function(){});n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CIUDADNOMBRE",gxz:"Z5CiudadNombre",gxold:"O5CiudadNombre",gxvar:"A5CiudadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5CiudadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z5CiudadNombre=n)},v2c:function(){gx.fn.setControlValue("CIUDADNOMBRE",gx.O.A5CiudadNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A5CiudadNombre=this.val())},val:function(){return gx.fn.getControlValue("CIUDADNOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(69,function(){});n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"BTN_ENTER",grid:0,evt:"e13034_client",std:"ENTER"};n[75]={id:75,fld:"",grid:0};n[76]={id:76,fld:"BTN_CANCEL",grid:0,evt:"e14034_client"};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"BTN_DELETE",grid:0,evt:"e20034_client",std:"DELETE"};n[79]={id:79,fld:"PROMPT_1",grid:4};n[80]={id:80,fld:"PROMPT_4",grid:4};this.A8LugarId=0;this.Z8LugarId=0;this.O8LugarId=0;this.A9LugarNombre="";this.Z9LugarNombre="";this.O9LugarNombre="";this.A40000LugarFoto_GXI="";this.A10LugarFoto="";this.Z10LugarFoto="";this.O10LugarFoto="";this.A1PaisId=0;this.Z1PaisId=0;this.O1PaisId=0;this.A2PaisNombre="";this.Z2PaisNombre="";this.O2PaisNombre="";this.A40001PaisBandera_GXI="";this.A3PaisBandera="";this.Z3PaisBandera="";this.O3PaisBandera="";this.A4CiudadId=0;this.Z4CiudadId=0;this.O4CiudadId=0;this.A5CiudadNombre="";this.Z5CiudadNombre="";this.O5CiudadNombre="";this.A40000LugarFoto_GXI="";this.A40001PaisBandera_GXI="";this.AV14Pgmname="";this.AV9TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV11Insert_PaisId=0;this.AV12Insert_CiudadId=0;this.AV15GXV1=0;this.AV13TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV7LugarId=0;this.AV10WebSession={};this.A8LugarId=0;this.A1PaisId=0;this.A4CiudadId=0;this.A9LugarNombre="";this.A10LugarFoto="";this.A2PaisNombre="";this.A3PaisBandera="";this.A5CiudadNombre="";this.Gx_mode="";this.Events={e12032_client:["AFTER TRN",!0],e13034_client:["ENTER",!0],e14034_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7LugarId",fld:"vLUGARID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0},{av:"AV7LugarId",fld:"vLUGARID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV14Pgmname",fld:"vPGMNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0}],[{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0},{av:"AV11Insert_PaisId",fld:"vINSERT_PAISID",pic:"ZZZ9"},{av:"AV12Insert_CiudadId",fld:"vINSERT_CIUDADID",pic:"ZZZ9"},{av:"AV15GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV13TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0}],[]];this.EvtParms.VALID_LUGARID=[[],[]];this.EvtParms.VALID_PAISID=[[{av:"A1PaisId",fld:"PAISID",pic:"ZZZ9"},{av:"A2PaisNombre",fld:"PAISNOMBRE",pic:""},{av:"A3PaisBandera",fld:"PAISBANDERA",pic:""},{av:"A40001PaisBandera_GXI",fld:"PAISBANDERA_GXI",pic:""}],[{av:"A2PaisNombre",fld:"PAISNOMBRE",pic:""},{av:"A3PaisBandera",fld:"PAISBANDERA",pic:""},{av:"A40001PaisBandera_GXI",fld:"PAISBANDERA_GXI",pic:""}]];this.EvtParms.VALID_CIUDADID=[[{av:"A1PaisId",fld:"PAISID",pic:"ZZZ9"},{av:"A4CiudadId",fld:"CIUDADID",pic:"ZZZ9"},{av:"A5CiudadNombre",fld:"CIUDADNOMBRE",pic:""}],[{av:"A5CiudadNombre",fld:"CIUDADNOMBRE",pic:""}]];this.setPrompt("PROMPT_1",[49]);this.setPrompt("PROMPT_4",[64]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7LugarId","vLUGARID",0,"int",4,0);this.setVCMap("AV11Insert_PaisId","vINSERT_PAISID",0,"int",4,0);this.setVCMap("AV12Insert_CiudadId","vINSERT_CIUDADID",0,"int",4,0);this.setVCMap("A40000LugarFoto_GXI","LUGARFOTO_GXI",0,"svchar",2048,0);this.setVCMap("A40001PaisBandera_GXI","PAISBANDERA_GXI",0,"svchar",2048,0);this.setVCMap("AV14Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV9TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);this.Initialize()});gx.wi(function(){gx.createParentObj(lugar)})