/*!   GeneXus C# 16_0_7-138086 on 2/16/2020 21:49:13.81
*/
gx.evt.autoSkip=!1;gx.define("entrada",!1,function(){this.ServerClass="entrada";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7EntradaId=gx.fn.getIntegerValue("vENTRADAID",",");this.AV11Insert_VentaId=gx.fn.getIntegerValue("vINSERT_VENTAID",",");this.A40000VentaFecha_GXI=gx.fn.getControlValue("VENTAFECHA_GXI");this.A40002EspectaculoPaisBandera_GXI=gx.fn.getControlValue("ESPECTACULOPAISBANDERA_GXI");this.A40001VentaPaisBandera_GXI=gx.fn.getControlValue("VENTAPAISBANDERA_GXI");this.AV13Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV9TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Entradaid=function(){return this.validCliEvt("Valid_Entradaid",0,function(){try{var n=gx.util.balloon.getNew("ENTRADAID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Ventaid=function(){return this.validSrvEvt("Valid_Ventaid",0).then(function(n){return n}.closure(this))};this.Valid_Espectaculoid=function(){return this.validCliEvt("Valid_Espectaculoid",0,function(){try{var n=gx.util.balloon.getNew("ESPECTACULOID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Ventapaisid=function(){return this.validCliEvt("Valid_Ventapaisid",0,function(){try{var n=gx.util.balloon.getNew("VENTAPAISID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Ventaciudadid=function(){return this.validCliEvt("Valid_Ventaciudadid",0,function(){try{var n=gx.util.balloon.getNew("VENTACIUDADID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Espectaculopaisid=function(){return this.validCliEvt("Valid_Espectaculopaisid",0,function(){try{var n=gx.util.balloon.getNew("ESPECTACULOPAISID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Espectaculociudadid=function(){return this.validCliEvt("Valid_Espectaculociudadid",0,function(){try{var n=gx.util.balloon.getNew("ESPECTACULOCIUDADID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e12072_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e13079_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14079_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119];this.GXLastCtrlId=119;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0,evt:"e15079_client",std:"FIRST"};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0,evt:"e16079_client",std:"PREVIOUS"};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0,evt:"e17079_client",std:"NEXT"};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0,evt:"e18079_client",std:"LAST"};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0,evt:"e19079_client",std:"SELECT"};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Entradaid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ENTRADAID",gxz:"Z39EntradaId",gxold:"O39EntradaId",gxvar:"A39EntradaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A39EntradaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z39EntradaId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ENTRADAID",gx.O.A39EntradaId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A39EntradaId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ENTRADAID",",")},nac:function(){return!(0==this.AV7EntradaId)}};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Ventaid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAID",gxz:"Z37VentaId",gxold:"O37VentaId",gxvar:"A37VentaId",ucs:[],op:[84,74,69,109,99,94,104,89,59,54,79,64,49,44],ip:[84,74,69,109,99,94,59,54,44,79,64,104,89,49,39],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A37VentaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z37VentaId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("VENTAID",gx.O.A37VentaId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A37VentaId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("VENTAID",",")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV11Insert_VentaId)}};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAFECHA",gxz:"Z38VentaFecha",gxold:"O38VentaFecha",gxvar:"A38VentaFecha",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A38VentaFecha=n)},v2z:function(n){n!==undefined&&(gx.O.Z38VentaFecha=n)},v2c:function(){gx.fn.setMultimediaValue("VENTAFECHA",gx.O.A38VentaFecha,gx.O.A40000VentaFecha_GXI)},c2v:function(){gx.O.A40000VentaFecha_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A38VentaFecha=this.val())},val:function(){return gx.fn.getBlobValue("VENTAFECHA")},val_GXI:function(){return gx.fn.getControlValue("VENTAFECHA_GXI")},gxvar_GXI:"A40000VentaFecha_GXI",nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Espectaculoid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOID",gxz:"Z34EspectaculoId",gxold:"O34EspectaculoId",gxvar:"A34EspectaculoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z34EspectaculoId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ESPECTACULOID",gx.O.A34EspectaculoId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ESPECTACULOID",",")},nac:gx.falseFn};this.declareDomainHdlr(49,function(){});n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULONOMBRE",gxz:"Z35EspectaculoNombre",gxold:"O35EspectaculoNombre",gxvar:"A35EspectaculoNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A35EspectaculoNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z35EspectaculoNombre=n)},v2c:function(){gx.fn.setControlValue("ESPECTACULONOMBRE",gx.O.A35EspectaculoNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A35EspectaculoNombre=this.val())},val:function(){return gx.fn.getControlValue("ESPECTACULONOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(54,function(){});n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"date",len:8,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOFECHA",gxz:"Z36EspectaculoFecha",gxold:"O36EspectaculoFecha",gxvar:"A36EspectaculoFecha",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A36EspectaculoFecha=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z36EspectaculoFecha=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ESPECTACULOFECHA",gx.O.A36EspectaculoFecha,0)},c2v:function(){this.val()!==undefined&&(gx.O.A36EspectaculoFecha=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("ESPECTACULOFECHA")},nac:gx.falseFn};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Ventapaisid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAPAISID",gxz:"Z24VentaPaisId",gxold:"O24VentaPaisId",gxvar:"A24VentaPaisId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A24VentaPaisId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z24VentaPaisId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("VENTAPAISID",gx.O.A24VentaPaisId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A24VentaPaisId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("VENTAPAISID",",")},nac:gx.falseFn};this.declareDomainHdlr(64,function(){});n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAPAISNOMBRE",gxz:"Z25VentaPaisNombre",gxold:"O25VentaPaisNombre",gxvar:"A25VentaPaisNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A25VentaPaisNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z25VentaPaisNombre=n)},v2c:function(){gx.fn.setControlValue("VENTAPAISNOMBRE",gx.O.A25VentaPaisNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A25VentaPaisNombre=this.val())},val:function(){return gx.fn.getControlValue("VENTAPAISNOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(69,function(){});n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAPAISBANDERA",gxz:"Z26VentaPaisBandera",gxold:"O26VentaPaisBandera",gxvar:"A26VentaPaisBandera",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A26VentaPaisBandera=n)},v2z:function(n){n!==undefined&&(gx.O.Z26VentaPaisBandera=n)},v2c:function(){gx.fn.setMultimediaValue("VENTAPAISBANDERA",gx.O.A26VentaPaisBandera,gx.O.A40001VentaPaisBandera_GXI)},c2v:function(){gx.O.A40001VentaPaisBandera_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A26VentaPaisBandera=this.val())},val:function(){return gx.fn.getBlobValue("VENTAPAISBANDERA")},val_GXI:function(){return gx.fn.getControlValue("VENTAPAISBANDERA_GXI")},gxvar_GXI:"A40001VentaPaisBandera_GXI",nac:gx.falseFn};n[75]={id:75,fld:"",grid:0};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Ventaciudadid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTACIUDADID",gxz:"Z27VentaCiudadId",gxold:"O27VentaCiudadId",gxvar:"A27VentaCiudadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A27VentaCiudadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z27VentaCiudadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("VENTACIUDADID",gx.O.A27VentaCiudadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A27VentaCiudadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("VENTACIUDADID",",")},nac:gx.falseFn};this.declareDomainHdlr(79,function(){});n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTACIUDADNOMBRE",gxz:"Z28VentaCiudadNombre",gxold:"O28VentaCiudadNombre",gxvar:"A28VentaCiudadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A28VentaCiudadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z28VentaCiudadNombre=n)},v2c:function(){gx.fn.setControlValue("VENTACIUDADNOMBRE",gx.O.A28VentaCiudadNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A28VentaCiudadNombre=this.val())},val:function(){return gx.fn.getControlValue("VENTACIUDADNOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(84,function(){});n[85]={id:85,fld:"",grid:0};n[86]={id:86,fld:"",grid:0};n[87]={id:87,fld:"",grid:0};n[88]={id:88,fld:"",grid:0};n[89]={id:89,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Espectaculopaisid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOPAISID",gxz:"Z19EspectaculoPaisId",gxold:"O19EspectaculoPaisId",gxvar:"A19EspectaculoPaisId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A19EspectaculoPaisId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19EspectaculoPaisId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ESPECTACULOPAISID",gx.O.A19EspectaculoPaisId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A19EspectaculoPaisId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ESPECTACULOPAISID",",")},nac:gx.falseFn};this.declareDomainHdlr(89,function(){});n[90]={id:90,fld:"",grid:0};n[91]={id:91,fld:"",grid:0};n[92]={id:92,fld:"",grid:0};n[93]={id:93,fld:"",grid:0};n[94]={id:94,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOPAISNOMBRE",gxz:"Z20EspectaculoPaisNombre",gxold:"O20EspectaculoPaisNombre",gxvar:"A20EspectaculoPaisNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A20EspectaculoPaisNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z20EspectaculoPaisNombre=n)},v2c:function(){gx.fn.setControlValue("ESPECTACULOPAISNOMBRE",gx.O.A20EspectaculoPaisNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A20EspectaculoPaisNombre=this.val())},val:function(){return gx.fn.getControlValue("ESPECTACULOPAISNOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(94,function(){});n[95]={id:95,fld:"",grid:0};n[96]={id:96,fld:"",grid:0};n[97]={id:97,fld:"",grid:0};n[98]={id:98,fld:"",grid:0};n[99]={id:99,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOPAISBANDERA",gxz:"Z21EspectaculoPaisBandera",gxold:"O21EspectaculoPaisBandera",gxvar:"A21EspectaculoPaisBandera",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A21EspectaculoPaisBandera=n)},v2z:function(n){n!==undefined&&(gx.O.Z21EspectaculoPaisBandera=n)},v2c:function(){gx.fn.setMultimediaValue("ESPECTACULOPAISBANDERA",gx.O.A21EspectaculoPaisBandera,gx.O.A40002EspectaculoPaisBandera_GXI)},c2v:function(){gx.O.A40002EspectaculoPaisBandera_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A21EspectaculoPaisBandera=this.val())},val:function(){return gx.fn.getBlobValue("ESPECTACULOPAISBANDERA")},val_GXI:function(){return gx.fn.getControlValue("ESPECTACULOPAISBANDERA_GXI")},gxvar_GXI:"A40002EspectaculoPaisBandera_GXI",nac:gx.falseFn};n[100]={id:100,fld:"",grid:0};n[101]={id:101,fld:"",grid:0};n[102]={id:102,fld:"",grid:0};n[103]={id:103,fld:"",grid:0};n[104]={id:104,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Espectaculociudadid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOCIUDADID",gxz:"Z22EspectaculoCiudadId",gxold:"O22EspectaculoCiudadId",gxvar:"A22EspectaculoCiudadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A22EspectaculoCiudadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z22EspectaculoCiudadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ESPECTACULOCIUDADID",gx.O.A22EspectaculoCiudadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A22EspectaculoCiudadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ESPECTACULOCIUDADID",",")},nac:gx.falseFn};this.declareDomainHdlr(104,function(){});n[105]={id:105,fld:"",grid:0};n[106]={id:106,fld:"",grid:0};n[107]={id:107,fld:"",grid:0};n[108]={id:108,fld:"",grid:0};n[109]={id:109,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOCIUDADNOMBRE",gxz:"Z23EspectaculoCiudadNombre",gxold:"O23EspectaculoCiudadNombre",gxvar:"A23EspectaculoCiudadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A23EspectaculoCiudadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z23EspectaculoCiudadNombre=n)},v2c:function(){gx.fn.setControlValue("ESPECTACULOCIUDADNOMBRE",gx.O.A23EspectaculoCiudadNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A23EspectaculoCiudadNombre=this.val())},val:function(){return gx.fn.getControlValue("ESPECTACULOCIUDADNOMBRE")},nac:gx.falseFn};this.declareDomainHdlr(109,function(){});n[110]={id:110,fld:"",grid:0};n[111]={id:111,fld:"",grid:0};n[112]={id:112,fld:"",grid:0};n[113]={id:113,fld:"",grid:0};n[114]={id:114,fld:"BTN_ENTER",grid:0,evt:"e13079_client",std:"ENTER"};n[115]={id:115,fld:"",grid:0};n[116]={id:116,fld:"BTN_CANCEL",grid:0,evt:"e14079_client"};n[117]={id:117,fld:"",grid:0};n[118]={id:118,fld:"BTN_DELETE",grid:0,evt:"e20079_client",std:"DELETE"};n[119]={id:119,fld:"PROMPT_37",grid:9};this.A39EntradaId=0;this.Z39EntradaId=0;this.O39EntradaId=0;this.A37VentaId=0;this.Z37VentaId=0;this.O37VentaId=0;this.A40000VentaFecha_GXI="";this.A38VentaFecha="";this.Z38VentaFecha="";this.O38VentaFecha="";this.A34EspectaculoId=0;this.Z34EspectaculoId=0;this.O34EspectaculoId=0;this.A35EspectaculoNombre="";this.Z35EspectaculoNombre="";this.O35EspectaculoNombre="";this.A36EspectaculoFecha=gx.date.nullDate();this.Z36EspectaculoFecha=gx.date.nullDate();this.O36EspectaculoFecha=gx.date.nullDate();this.A24VentaPaisId=0;this.Z24VentaPaisId=0;this.O24VentaPaisId=0;this.A25VentaPaisNombre="";this.Z25VentaPaisNombre="";this.O25VentaPaisNombre="";this.A40001VentaPaisBandera_GXI="";this.A26VentaPaisBandera="";this.Z26VentaPaisBandera="";this.O26VentaPaisBandera="";this.A27VentaCiudadId=0;this.Z27VentaCiudadId=0;this.O27VentaCiudadId=0;this.A28VentaCiudadNombre="";this.Z28VentaCiudadNombre="";this.O28VentaCiudadNombre="";this.A19EspectaculoPaisId=0;this.Z19EspectaculoPaisId=0;this.O19EspectaculoPaisId=0;this.A20EspectaculoPaisNombre="";this.Z20EspectaculoPaisNombre="";this.O20EspectaculoPaisNombre="";this.A40002EspectaculoPaisBandera_GXI="";this.A21EspectaculoPaisBandera="";this.Z21EspectaculoPaisBandera="";this.O21EspectaculoPaisBandera="";this.A22EspectaculoCiudadId=0;this.Z22EspectaculoCiudadId=0;this.O22EspectaculoCiudadId=0;this.A23EspectaculoCiudadNombre="";this.Z23EspectaculoCiudadNombre="";this.O23EspectaculoCiudadNombre="";this.A40000VentaFecha_GXI="";this.A40001VentaPaisBandera_GXI="";this.A40002EspectaculoPaisBandera_GXI="";this.AV13Pgmname="";this.AV9TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV11Insert_VentaId=0;this.AV14GXV1=0;this.AV12TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV7EntradaId=0;this.AV10WebSession={};this.A39EntradaId=0;this.A37VentaId=0;this.A38VentaFecha="";this.A34EspectaculoId=0;this.A35EspectaculoNombre="";this.A36EspectaculoFecha=gx.date.nullDate();this.A24VentaPaisId=0;this.A25VentaPaisNombre="";this.A26VentaPaisBandera="";this.A27VentaCiudadId=0;this.A28VentaCiudadNombre="";this.A19EspectaculoPaisId=0;this.A20EspectaculoPaisNombre="";this.A21EspectaculoPaisBandera="";this.A22EspectaculoCiudadId=0;this.A23EspectaculoCiudadNombre="";this.Gx_mode="";this.Events={e12072_client:["AFTER TRN",!0],e13079_client:["ENTER",!0],e14079_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7EntradaId",fld:"vENTRADAID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0},{av:"AV7EntradaId",fld:"vENTRADAID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0}],[{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0},{av:"AV11Insert_VentaId",fld:"vINSERT_VENTAID",pic:"ZZZ9"},{av:"AV14GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV12TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0}],[]];this.EvtParms.VALID_ENTRADAID=[[],[]];this.EvtParms.VALID_VENTAID=[[{av:"A37VentaId",fld:"VENTAID",pic:"ZZZ9"},{av:"A34EspectaculoId",fld:"ESPECTACULOID",pic:"ZZZ9"},{av:"A19EspectaculoPaisId",fld:"ESPECTACULOPAISID",pic:"ZZZ9"},{av:"A22EspectaculoCiudadId",fld:"ESPECTACULOCIUDADID",pic:"ZZZ9"},{av:"A24VentaPaisId",fld:"VENTAPAISID",pic:"ZZZ9"},{av:"A27VentaCiudadId",fld:"VENTACIUDADID",pic:"ZZZ9"},{av:"A38VentaFecha",fld:"VENTAFECHA",pic:""},{av:"A40000VentaFecha_GXI",fld:"VENTAFECHA_GXI",pic:""},{av:"A35EspectaculoNombre",fld:"ESPECTACULONOMBRE",pic:""},{av:"A36EspectaculoFecha",fld:"ESPECTACULOFECHA",pic:""},{av:"A20EspectaculoPaisNombre",fld:"ESPECTACULOPAISNOMBRE",pic:""},{av:"A21EspectaculoPaisBandera",fld:"ESPECTACULOPAISBANDERA",pic:""},{av:"A40002EspectaculoPaisBandera_GXI",fld:"ESPECTACULOPAISBANDERA_GXI",pic:""},{av:"A23EspectaculoCiudadNombre",fld:"ESPECTACULOCIUDADNOMBRE",pic:""},{av:"A25VentaPaisNombre",fld:"VENTAPAISNOMBRE",pic:""},{av:"A26VentaPaisBandera",fld:"VENTAPAISBANDERA",pic:""},{av:"A40001VentaPaisBandera_GXI",fld:"VENTAPAISBANDERA_GXI",pic:""},{av:"A28VentaCiudadNombre",fld:"VENTACIUDADNOMBRE",pic:""}],[{av:"A38VentaFecha",fld:"VENTAFECHA",pic:""},{av:"A40000VentaFecha_GXI",fld:"VENTAFECHA_GXI",pic:""},{av:"A34EspectaculoId",fld:"ESPECTACULOID",pic:"ZZZ9"},{av:"A24VentaPaisId",fld:"VENTAPAISID",pic:"ZZZ9"},{av:"A27VentaCiudadId",fld:"VENTACIUDADID",pic:"ZZZ9"},{av:"A35EspectaculoNombre",fld:"ESPECTACULONOMBRE",pic:""},{av:"A36EspectaculoFecha",fld:"ESPECTACULOFECHA",pic:""},{av:"A19EspectaculoPaisId",fld:"ESPECTACULOPAISID",pic:"ZZZ9"},{av:"A22EspectaculoCiudadId",fld:"ESPECTACULOCIUDADID",pic:"ZZZ9"},{av:"A20EspectaculoPaisNombre",fld:"ESPECTACULOPAISNOMBRE",pic:""},{av:"A21EspectaculoPaisBandera",fld:"ESPECTACULOPAISBANDERA",pic:""},{av:"A40002EspectaculoPaisBandera_GXI",fld:"ESPECTACULOPAISBANDERA_GXI",pic:""},{av:"A23EspectaculoCiudadNombre",fld:"ESPECTACULOCIUDADNOMBRE",pic:""},{av:"A25VentaPaisNombre",fld:"VENTAPAISNOMBRE",pic:""},{av:"A26VentaPaisBandera",fld:"VENTAPAISBANDERA",pic:""},{av:"A40001VentaPaisBandera_GXI",fld:"VENTAPAISBANDERA_GXI",pic:""},{av:"A28VentaCiudadNombre",fld:"VENTACIUDADNOMBRE",pic:""}]];this.EvtParms.VALID_ESPECTACULOID=[[],[]];this.EvtParms.VALID_VENTAPAISID=[[],[]];this.EvtParms.VALID_VENTACIUDADID=[[],[]];this.EvtParms.VALID_ESPECTACULOPAISID=[[],[]];this.EvtParms.VALID_ESPECTACULOCIUDADID=[[],[]];this.setPrompt("PROMPT_37",[39]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7EntradaId","vENTRADAID",0,"int",4,0);this.setVCMap("AV11Insert_VentaId","vINSERT_VENTAID",0,"int",4,0);this.setVCMap("A40000VentaFecha_GXI","VENTAFECHA_GXI",0,"svchar",2048,0);this.setVCMap("A40002EspectaculoPaisBandera_GXI","ESPECTACULOPAISBANDERA_GXI",0,"svchar",2048,0);this.setVCMap("A40001VentaPaisBandera_GXI","VENTAPAISBANDERA_GXI",0,"svchar",2048,0);this.setVCMap("AV13Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV9TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);this.Initialize()});gx.wi(function(){gx.createParentObj(entrada)})