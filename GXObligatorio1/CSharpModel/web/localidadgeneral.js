/*!   GeneXus C# 16_0_7-138086 on 2/16/2020 17:38:9.81
*/
gx.evt.autoSkip=!1;gx.define("localidadgeneral",!0,function(n){this.ServerClass="localidadgeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Localidadid=function(){return this.validCliEvt("Valid_Localidadid",0,function(){try{var n=gx.util.balloon.getNew("LOCALIDADID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e110t1_client=function(){return this.clearMessages(),this.call("localidad.aspx",["UPD",this.A11LocalidadId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e120t1_client=function(){return this.clearMessages(),this.call("localidad.aspx",["DLT",this.A11LocalidadId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e150t2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160t2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43];this.GXLastCtrlId=43;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0,evt:"e110t1_client"};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0,evt:"e120t1_client"};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Localidadid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADID",gxz:"Z11LocalidadId",gxold:"O11LocalidadId",gxvar:"A11LocalidadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11LocalidadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11LocalidadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("LOCALIDADID",gx.O.A11LocalidadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A11LocalidadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("LOCALIDADID",",")},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADNOMBRE",gxz:"Z12LocalidadNombre",gxold:"O12LocalidadNombre",gxvar:"A12LocalidadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A12LocalidadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z12LocalidadNombre=n)},v2c:function(){gx.fn.setControlValue("LOCALIDADNOMBRE",gx.O.A12LocalidadNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A12LocalidadNombre=this.val())},val:function(){return gx.fn.getControlValue("LOCALIDADNOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(23,function(){});t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:5,dec:0,sign:!1,pic:"ZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADCAPACIDAD",gxz:"Z13LocalidadCapacidad",gxold:"O13LocalidadCapacidad",gxvar:"A13LocalidadCapacidad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A13LocalidadCapacidad=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13LocalidadCapacidad=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("LOCALIDADCAPACIDAD",gx.O.A13LocalidadCapacidad,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13LocalidadCapacidad=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("LOCALIDADCAPACIDAD",",")},nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADPRECIO",gxz:"Z14LocalidadPrecio",gxold:"O14LocalidadPrecio",gxvar:"A14LocalidadPrecio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A14LocalidadPrecio=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z14LocalidadPrecio=gx.fn.toDecimalValue(n,",","."))},v2c:function(){gx.fn.setDecimalValue("LOCALIDADPRECIO",gx.O.A14LocalidadPrecio,2,".")},c2v:function(){this.val()!==undefined&&(gx.O.A14LocalidadPrecio=this.val())},val:function(){return gx.fn.getDecimalValue("LOCALIDADPRECIO",",",".")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"int",len:5,dec:0,sign:!1,pic:"ZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADESVENDIDAS",gxz:"Z15LocalidadesVendidas",gxold:"O15LocalidadesVendidas",gxvar:"A15LocalidadesVendidas",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A15LocalidadesVendidas=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z15LocalidadesVendidas=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("LOCALIDADESVENDIDAS",gx.O.A15LocalidadesVendidas,0)},c2v:function(){this.val()!==undefined&&(gx.O.A15LocalidadesVendidas=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("LOCALIDADESVENDIDAS",",")},nac:gx.falseFn};t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"int",len:5,dec:0,sign:!1,pic:"ZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADESDISPONIBLES",gxz:"Z16LocalidadesDisponibles",gxold:"O16LocalidadesDisponibles",gxvar:"A16LocalidadesDisponibles",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A16LocalidadesDisponibles=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z16LocalidadesDisponibles=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("LOCALIDADESDISPONIBLES",gx.O.A16LocalidadesDisponibles,0)},c2v:function(){this.val()!==undefined&&(gx.O.A16LocalidadesDisponibles=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("LOCALIDADESDISPONIBLES",",")},nac:gx.falseFn};this.A11LocalidadId=0;this.Z11LocalidadId=0;this.O11LocalidadId=0;this.A12LocalidadNombre="";this.Z12LocalidadNombre="";this.O12LocalidadNombre="";this.A13LocalidadCapacidad=0;this.Z13LocalidadCapacidad=0;this.O13LocalidadCapacidad=0;this.A14LocalidadPrecio=0;this.Z14LocalidadPrecio=0;this.O14LocalidadPrecio=0;this.A15LocalidadesVendidas=0;this.Z15LocalidadesVendidas=0;this.O15LocalidadesVendidas=0;this.A16LocalidadesDisponibles=0;this.Z16LocalidadesDisponibles=0;this.O16LocalidadesDisponibles=0;this.A11LocalidadId=0;this.A12LocalidadNombre="";this.A13LocalidadCapacidad=0;this.A14LocalidadPrecio=0;this.A15LocalidadesVendidas=0;this.A16LocalidadesDisponibles=0;this.Events={e150t2_client:["ENTER",!0],e160t2_client:["CANCEL",!0],e110t1_client:["'DOUPDATE'",!1],e120t1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[{av:"A11LocalidadId",fld:"LOCALIDADID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6LocalidadId",fld:"vLOCALIDADID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A11LocalidadId",fld:"LOCALIDADID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A11LocalidadId",fld:"LOCALIDADID",pic:"ZZZ9"}],[]];this.EvtParms.VALID_LOCALIDADID=[[],[]];this.Initialize()})