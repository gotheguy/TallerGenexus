/*!   GeneXus C# 16_0_7-138086 on 2/18/2020 22:53:7.83
*/
gx.evt.autoSkip=!1;gx.define("espectaculoventawc",!0,function(n){var t,i;this.ServerClass="espectaculoventawc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6EspectaculoId=gx.fn.getIntegerValue("vESPECTACULOID",",");this.AV6EspectaculoId=gx.fn.getIntegerValue("vESPECTACULOID",",")};this.Valid_Ventapaisid=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Ventapaisid",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("VENTAPAISID",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Ventaciudadid=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Ventaciudadid",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("VENTACIUDADID",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Espectaculopaisid=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Espectaculopaisid",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("ESPECTACULOPAISID",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Espectaculociudadid=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Espectaculociudadid",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("ESPECTACULOCIUDADID",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e111v2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e141v2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e151v2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39];this.GXLastCtrlId=39;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"espectaculoventawc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(37,21,"VENTAID","Id","","VentaId","int",0,"px",4,4,"right",null,[],37,"VentaId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addBitmap(38,"VENTAFECHA",22,0,"px",17,"px",null,"","Fecha","DescriptionAttribute","WWColumn");i.addSingleLineEdit(24,23,"VENTAPAISID","Pais Id","","VentaPaisId","int",0,"px",4,4,"right",null,[],24,"VentaPaisId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(25,24,"VENTAPAISNOMBRE","Pais Nombre","","VentaPaisNombre","char",0,"px",100,80,"left",null,[],25,"VentaPaisNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addBitmap(26,"VENTAPAISBANDERA",25,0,"px",17,"px",null,"","Pais Bandera","ImageAttribute","WWColumn WWOptionalColumn");i.addSingleLineEdit(27,26,"VENTACIUDADID","Ciudad Id","","VentaCiudadId","int",0,"px",4,4,"right",null,[],27,"VentaCiudadId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(28,27,"VENTACIUDADNOMBRE","Ciudad Nombre","","VentaCiudadNombre","char",0,"px",100,80,"left",null,[],28,"VentaCiudadNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(19,28,"ESPECTACULOPAISID","Pais Id","","EspectaculoPaisId","int",0,"px",4,4,"right",null,[],19,"EspectaculoPaisId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(20,29,"ESPECTACULOPAISNOMBRE","Pais Nombre","","EspectaculoPaisNombre","char",0,"px",100,80,"left",null,[],20,"EspectaculoPaisNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addBitmap(21,"ESPECTACULOPAISBANDERA",30,0,"px",17,"px",null,"","Pais Bandera","ImageAttribute","WWColumn WWOptionalColumn");i.addSingleLineEdit(22,31,"ESPECTACULOCIUDADID","Ciudad Id","","EspectaculoCiudadId","int",0,"px",4,4,"right",null,[],22,"EspectaculoCiudadId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(23,32,"ESPECTACULOCIUDADNOMBRE","Ciudad Nombre","","EspectaculoCiudadNombre","char",0,"px",100,80,"left",null,[],23,"EspectaculoCiudadNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(40,33,"VENTATOTAL","Total","","VentaTotal","int",0,"px",4,4,"right",null,[],40,"VentaTotal",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit("Update",34,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");i.addSingleLineEdit("Delete",35,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0,evt:"e111v2_client"};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAID",gxz:"Z37VentaId",gxold:"O37VentaId",gxvar:"A37VentaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A37VentaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z37VentaId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("VENTAID",n||gx.fn.currentGridRowImpl(20),gx.O.A37VentaId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A37VentaId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("VENTAID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAFECHA",gxz:"Z38VentaFecha",gxold:"O38VentaFecha",gxvar:"A38VentaFecha",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A38VentaFecha=n)},v2z:function(n){n!==undefined&&(gx.O.Z38VentaFecha=n)},v2c:function(n){gx.fn.setGridMultimediaValue("VENTAFECHA",n||gx.fn.currentGridRowImpl(20),gx.O.A38VentaFecha,gx.O.A40000VentaFecha_GXI)},c2v:function(n){gx.O.A40000VentaFecha_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.A38VentaFecha=this.val(n))},val:function(n){return gx.fn.getGridControlValue("VENTAFECHA",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("VENTAFECHA_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"A40000VentaFecha_GXI",nac:gx.falseFn};t[23]={id:23,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Ventapaisid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAPAISID",gxz:"Z24VentaPaisId",gxold:"O24VentaPaisId",gxvar:"A24VentaPaisId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A24VentaPaisId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z24VentaPaisId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("VENTAPAISID",n||gx.fn.currentGridRowImpl(20),gx.O.A24VentaPaisId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A24VentaPaisId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("VENTAPAISID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAPAISNOMBRE",gxz:"Z25VentaPaisNombre",gxold:"O25VentaPaisNombre",gxvar:"A25VentaPaisNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A25VentaPaisNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z25VentaPaisNombre=n)},v2c:function(n){gx.fn.setGridControlValue("VENTAPAISNOMBRE",n||gx.fn.currentGridRowImpl(20),gx.O.A25VentaPaisNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A25VentaPaisNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("VENTAPAISNOMBRE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[25]={id:25,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTAPAISBANDERA",gxz:"Z26VentaPaisBandera",gxold:"O26VentaPaisBandera",gxvar:"A26VentaPaisBandera",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A26VentaPaisBandera=n)},v2z:function(n){n!==undefined&&(gx.O.Z26VentaPaisBandera=n)},v2c:function(n){gx.fn.setGridMultimediaValue("VENTAPAISBANDERA",n||gx.fn.currentGridRowImpl(20),gx.O.A26VentaPaisBandera,gx.O.A40001VentaPaisBandera_GXI)},c2v:function(n){gx.O.A40001VentaPaisBandera_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.A26VentaPaisBandera=this.val(n))},val:function(n){return gx.fn.getGridControlValue("VENTAPAISBANDERA",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("VENTAPAISBANDERA_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"A40001VentaPaisBandera_GXI",nac:gx.falseFn};t[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Ventaciudadid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTACIUDADID",gxz:"Z27VentaCiudadId",gxold:"O27VentaCiudadId",gxvar:"A27VentaCiudadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A27VentaCiudadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z27VentaCiudadId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("VENTACIUDADID",n||gx.fn.currentGridRowImpl(20),gx.O.A27VentaCiudadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A27VentaCiudadId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("VENTACIUDADID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[27]={id:27,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTACIUDADNOMBRE",gxz:"Z28VentaCiudadNombre",gxold:"O28VentaCiudadNombre",gxvar:"A28VentaCiudadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A28VentaCiudadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z28VentaCiudadNombre=n)},v2c:function(n){gx.fn.setGridControlValue("VENTACIUDADNOMBRE",n||gx.fn.currentGridRowImpl(20),gx.O.A28VentaCiudadNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A28VentaCiudadNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("VENTACIUDADNOMBRE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[28]={id:28,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Espectaculopaisid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOPAISID",gxz:"Z19EspectaculoPaisId",gxold:"O19EspectaculoPaisId",gxvar:"A19EspectaculoPaisId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A19EspectaculoPaisId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19EspectaculoPaisId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESPECTACULOPAISID",n||gx.fn.currentGridRowImpl(20),gx.O.A19EspectaculoPaisId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A19EspectaculoPaisId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("ESPECTACULOPAISID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[29]={id:29,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOPAISNOMBRE",gxz:"Z20EspectaculoPaisNombre",gxold:"O20EspectaculoPaisNombre",gxvar:"A20EspectaculoPaisNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A20EspectaculoPaisNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z20EspectaculoPaisNombre=n)},v2c:function(n){gx.fn.setGridControlValue("ESPECTACULOPAISNOMBRE",n||gx.fn.currentGridRowImpl(20),gx.O.A20EspectaculoPaisNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A20EspectaculoPaisNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("ESPECTACULOPAISNOMBRE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[30]={id:30,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOPAISBANDERA",gxz:"Z21EspectaculoPaisBandera",gxold:"O21EspectaculoPaisBandera",gxvar:"A21EspectaculoPaisBandera",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A21EspectaculoPaisBandera=n)},v2z:function(n){n!==undefined&&(gx.O.Z21EspectaculoPaisBandera=n)},v2c:function(n){gx.fn.setGridMultimediaValue("ESPECTACULOPAISBANDERA",n||gx.fn.currentGridRowImpl(20),gx.O.A21EspectaculoPaisBandera,gx.O.A40002EspectaculoPaisBandera_GXI)},c2v:function(n){gx.O.A40002EspectaculoPaisBandera_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.A21EspectaculoPaisBandera=this.val(n))},val:function(n){return gx.fn.getGridControlValue("ESPECTACULOPAISBANDERA",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("ESPECTACULOPAISBANDERA_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"A40002EspectaculoPaisBandera_GXI",nac:gx.falseFn};t[31]={id:31,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Espectaculociudadid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOCIUDADID",gxz:"Z22EspectaculoCiudadId",gxold:"O22EspectaculoCiudadId",gxvar:"A22EspectaculoCiudadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A22EspectaculoCiudadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z22EspectaculoCiudadId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESPECTACULOCIUDADID",n||gx.fn.currentGridRowImpl(20),gx.O.A22EspectaculoCiudadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A22EspectaculoCiudadId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("ESPECTACULOCIUDADID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[32]={id:32,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOCIUDADNOMBRE",gxz:"Z23EspectaculoCiudadNombre",gxold:"O23EspectaculoCiudadNombre",gxvar:"A23EspectaculoCiudadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A23EspectaculoCiudadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z23EspectaculoCiudadNombre=n)},v2c:function(n){gx.fn.setGridControlValue("ESPECTACULOCIUDADNOMBRE",n||gx.fn.currentGridRowImpl(20),gx.O.A23EspectaculoCiudadNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A23EspectaculoCiudadNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("ESPECTACULOCIUDADNOMBRE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[33]={id:33,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VENTATOTAL",gxz:"Z40VentaTotal",gxold:"O40VentaTotal",gxvar:"A40VentaTotal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A40VentaTotal=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z40VentaTotal=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("VENTATOTAL",n||gx.fn.currentGridRowImpl(20),gx.O.A40VentaTotal,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A40VentaTotal=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("VENTATOTAL",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[34]={id:34,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV11Update",gxold:"OV11Update",gxvar:"AV11Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV11Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV11Update,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV11Update=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[35]={id:35,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV12Delete",gxold:"OV12Delete",gxvar:"AV12Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV12Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Delete,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV12Delete=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOID",gxz:"Z34EspectaculoId",gxold:"O34EspectaculoId",gxvar:"A34EspectaculoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z34EspectaculoId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ESPECTACULOID",gx.O.A34EspectaculoId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ESPECTACULOID",",")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});this.Z37VentaId=0;this.O37VentaId=0;this.Z38VentaFecha="";this.O38VentaFecha="";this.Z24VentaPaisId=0;this.O24VentaPaisId=0;this.Z25VentaPaisNombre="";this.O25VentaPaisNombre="";this.Z26VentaPaisBandera="";this.O26VentaPaisBandera="";this.Z27VentaCiudadId=0;this.O27VentaCiudadId=0;this.Z28VentaCiudadNombre="";this.O28VentaCiudadNombre="";this.Z19EspectaculoPaisId=0;this.O19EspectaculoPaisId=0;this.Z20EspectaculoPaisNombre="";this.O20EspectaculoPaisNombre="";this.Z21EspectaculoPaisBandera="";this.O21EspectaculoPaisBandera="";this.Z22EspectaculoCiudadId=0;this.O22EspectaculoCiudadId=0;this.Z23EspectaculoCiudadNombre="";this.O23EspectaculoCiudadNombre="";this.Z40VentaTotal=0;this.O40VentaTotal=0;this.ZV11Update="";this.OV11Update="";this.ZV12Delete="";this.OV12Delete="";this.A34EspectaculoId=0;this.Z34EspectaculoId=0;this.O34EspectaculoId=0;this.A34EspectaculoId=0;this.A40000VentaFecha_GXI="";this.A40001VentaPaisBandera_GXI="";this.A40002EspectaculoPaisBandera_GXI="";this.AV6EspectaculoId=0;this.A37VentaId=0;this.A38VentaFecha="";this.A24VentaPaisId=0;this.A25VentaPaisNombre="";this.A26VentaPaisBandera="";this.A27VentaCiudadId=0;this.A28VentaCiudadNombre="";this.A19EspectaculoPaisId=0;this.A20EspectaculoPaisNombre="";this.A21EspectaculoPaisBandera="";this.A22EspectaculoCiudadId=0;this.A23EspectaculoCiudadNombre="";this.A40VentaTotal=0;this.AV11Update="";this.AV12Delete="";this.Events={e111v2_client:["'DOINSERT'",!0],e141v2_client:["ENTER",!0],e151v2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EspectaculoId",fld:"vESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6EspectaculoId",fld:"vESPECTACULOID",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("ESPECTACULOID","Visible")',ctrl:"ESPECTACULOID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A37VentaId",fld:"VENTAID",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A37VentaId",fld:"VENTAID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EspectaculoId",fld:"vESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EspectaculoId",fld:"vESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EspectaculoId",fld:"vESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EspectaculoId",fld:"vESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.VALID_VENTAPAISID=[[],[]];this.EvtParms.VALID_VENTACIUDADID=[[],[]];this.EvtParms.VALID_ESPECTACULOPAISID=[[],[]];this.EvtParms.VALID_ESPECTACULOCIUDADID=[[],[]];this.setVCMap("AV6EspectaculoId","vESPECTACULOID",0,"int",4,0);this.setVCMap("AV6EspectaculoId","vESPECTACULOID",0,"int",4,0);this.setVCMap("AV6EspectaculoId","vESPECTACULOID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6EspectaculoId"});i.addRefreshingVar({rfrVar:"AV11Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV12Delete",rfrProp:"Value",gxAttId:"Delete"});i.addRefreshingParm({rfrVar:"AV6EspectaculoId"});i.addRefreshingParm({rfrVar:"AV11Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingParm({rfrVar:"AV12Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()})