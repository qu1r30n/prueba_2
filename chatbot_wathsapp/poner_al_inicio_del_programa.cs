﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chatbot_wathsapp.clases.herramientas;

namespace chatbot_wathsapp.clases
{
    class poner_al_inicio_del_programa
    {
        Tex_base bas = new Tex_base();
        operaciones_arreglos op_arreglos = new operaciones_arreglos();

        int G_configuracion = var_fun_GG.GG_indice_donde_comensar;
        public string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        public string[] G_separador_para_funciones_espesificas_ = var_fun_GG.GG_caracter_separacion_funciones_espesificas;

        

        public void inicio()
        {

            string direccion_archivo_de_direcciones_de_bd = "archivos_iniciales\\inicio.txt";
            string fila_inicial = "direccion_de_las_bases_de_datos" + bas.GG_separador_para_funciones_espesificas_[0] + "fila_inicial" + bas.GG_separador_para_funciones_espesificas_[0] + "arreglo_de_filas_separado_por_§//posdata_solo_ir_agregando_archivos_asta_abajo_por_que_las_filas_ya_son_ocupadas_por_el_programa_y_no_borrar";



            string[] agregar_filas =
            {
                // empiesa desde el 1 por que el 0 es de los archivos iniciales
                /*1*/ "config\\tienda\\inventario\\inventario.txt~producto|contenido|tipo_medida|precio_venta|cod_barras|cantidad|costo_comp|provedor|grupo|no poner nada|cant_produc_x_paquet|tipo_de_producto|ligar_produc_sab|impuestos|parte_de_que_producto~",
                /*2*/ "config\\sismul2\\negocio.txt~0_id_usuario|1_id_patrocinador_comp|2_tabla_patrocinador_comp|3_id_encargado_simple|4_tabla_encargado_simple|5_diner|6_pago_directo|7_pago_inderecto|8_datos|~1|1|patrocinadores_complejos|1|negocio|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|§2|1|patrocinadores_complejos|1|negocio|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|§3|1|patrocinadores_complejos|2|negocio|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|§4|2|patrocinadores_complejos|3|negocio|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|§5|3|patrocinadores_complejos|4|negocio|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|",
                /*3*/ "config\\sismul2\\patrocinadores_complejos.txt~0_id_usuario|1_id_patrocinador_comp|2_tabla_patrocinador_comp|3_id_encargado_simple|4_tabla_encargado_simple|5_diner|6_pago_directo|7_pago_inderecto|8_datos|~1|1|patrocinadores_complejos|1|patrocinadores_complejos|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|§2|1|patrocinadores_complejos|1|patrocinadores_complejos|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|§3|1|patrocinadores_complejos|2|patrocinadores_complejos|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|§4|1|patrocinadores_complejos|3|patrocinadores_complejos|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|§5|1|patrocinadores_complejos|4|patrocinadores_complejos|0|0|0|nombre°ap_p°ap_m°0°banco°curp°7487660000°direccion°colonia°municipio°estado°correo|",
                /*4*/ "config\\sismul2\\porcentajes\\porcentajes.txt~fila1:_porsentage_venta_directa_fila2:porcentajes_simple_fila3:_porcentajes_complejo_fila4:_porcentaje_venta_directa_complejo~15§10|5§10|10|10§15",
                
                /*5*/ "config\\chatbot\\info_para_comandos_chatbot\\00_paginaweb.txt~info_para_comandos~http://web.whatsapp.com/",
                /*6*/ "config\\chatbot\\info_para_comandos_chatbot\\01_ya_entrado_en_la_mensajeria.txt~info_para_comandos~side",
                /*7*/ "config\\chatbot\\info_para_comandos_chatbot\\02_chequeo_no_leidos.txt~info_para_comandos~//span[contains(@aria-label, 'mensajes no leídos') or contains(@aria-label, 'mensaje no leído')]",
                /*8*/ "config\\chatbot\\info_para_comandos_chatbot\\03_clickeo.txt~info_para_comandos~//ancestor::div[@class='_ak8k']",
                /*9*/ "config\\chatbot\\info_para_comandos_chatbot\\04_lectura_del_mensage.txt~info_para_comandos~//div[contains(@class, 'message-in')]//span[contains(@class, '_ao3e')]",
                /*10*/ "config\\chatbot\\info_para_comandos_chatbot\\05_reconocer_textbox_de_envio.txt~info_para_comandos~//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[2]§//*[@id=\"side\"]/div[1]/div/div[2]/div[2]/div/div[1]/p/br§//*[@id='main']/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]",
                /*11*/ "config\\chatbot\\info_para_comandos_chatbot\\06_buscar_nombre.txt~info_para_comandos~//span[contains(@title, '",

                /*12*/ "config\\chatbot\\info_para_comandos_chatbot\\07_nombre_del_clikeado.txt~info_para_comandos~//header[@class='AmmtE']//div[@class='_aou8 _aj_h']§//*[@id='main']/header/div[2]/div[1]/div/span",
                /*13*/ "config\\chatbot\\01_mensaje_bienvenida_inicio.txt~mensajes_A_enviar_cuando_resiva_un_mensage~mensaje bienvenida",
                /*14*/ "config\\chatbot\\02_mensaje_bienvenida_final.txt~mensaje_abajo_de_los_productos~mensaje abajo de los productos",
                /*15*/ "config\\chatbot\\03_productos.txt~nombre_del_producto|precio~producto1|1§producto2|2§producto3|3",
                /*16*/ "config\\chatbot\\04_mensaje_extra_despues_de_la_venta.txt~mensajes_despues_de_la_venta~mensaje despues de la venta",

                /*17*/ "config\\chatbot\\05_encargados.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap~Encargados",
                /*18*/ "config\\chatbot\\06_supervisores.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap~Supervisores",
                /*19*/ "config\\chatbot\\07_contadores.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap~Contadores",
                /*20*/ "config\\chatbot\\08_vendedores.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap~Vendedores",
                /*21*/ "config\\chatbot\\09_repartidores.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap~Repartidores",
                /*22*/ "config\\chatbot\\10_reg_mensaje.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap_y_envia_todos_los_mensajes_recibidos~Reg_mensaje",
                
                /*23*/ "config\\chatbot\\configuracion_programador.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap_y_este_para_funciones_especificas_echas_por_el_programador~",
                /*24*/ "config\\chatbot\\poner_1_si_recargaras_los_archivos.txt~si_la_primera_linea_tiene_1_lee_el_archivo_si_es_otro_lo_toma_desde_el_arreglo~",
                /*25*/ "config\\chatbot\\registros\\folios_a_checar\\folio_ventas.txt~folio_venta|añomesdiahoraminutosegundo|total|operacion|producto1¬precio1°pedido2¬precio2|vendedor|num_celular_vendedor|repartidor|datos_comprador°datos_comprador|datos_extra1°dato_extra2~",
                
                /*26*/ "config\\chatbot\\14_tesoreros.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap~Tesoreros",
                /*27*/ "config\\registros\\ventas.txt~folio|añomesdiahoraminutosegundo|total|lugar|producto1¬precio1°pedido2¬precio2|datos_extras~",
                /*28*/ "config\\registros\\compra.txt~folio|añomesdiahoraminutosegundo|total|lugar|producto1¬precio1°pedido2¬precio2|datos_extras~",
                /*29*/ "config\\chatbot\\11_productos_del_dia.txt~nombre_del_producto|precio~producto1|1§producto2|2§producto3|3",
                /*30*/ "config\\chatbot\\12_confirmadores.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap~Confirmadores",
                /*31*/ "config\\chatbot\\registros\\pedidos\\numeros_a_enviar_mensaje_de_lo_que_hay.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap~",
                /*32*/ "config\\chatbot\\registros\\pedidos\\mesas_fonda_cocina.txt~mesa|codigo°nombre_pedido°cantidad|total|datos_extras~",
                /*33*/ "config\\chatbot\\registros\\pedidos\\pedidos_con_horario.txt~horar|recordatorio|dias~",
                /*33*/ "config\\chatbot\\registros\\rut\\rutas_clientes.txt~horar|recordatorio|dias~",
                /*34*/ "config\\chatbot\\13_cocina_fonda.txt~nombre_o_numero_de_telefono_que_aparece_en_el_watsap~Cocina_Fonda",
            };

            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(direccion_archivo_de_direcciones_de_bd, fila_inicial, agregar_filas, caracter_separacion_fun_esp_objeto: G_separador_para_funciones_espesificas_[2]);



            //Tex_base.GG_dir_bd_y_valor_inicial_bidimencional = op_arreglos.agregar_registro_del_array_bidimensional(Tex_base.GG_dir_bd_y_valor_inicial_bidimencional, direccion_archivo_de_direcciones_de_bd, new string[] { bas.G_separador_para_funciones_espesificas });

            for (int i = G_configuracion; i < Tex_base.GG_base_arreglo_de_arreglos[0].Length; i++)
            {
                
                string[] espliteados_direcciones_bases_datos_y_fila_inicial = Tex_base.GG_base_arreglo_de_arreglos[0][i].Split(bas.GG_separador_para_funciones_espesificas_[0][0]);
                string[] filas_iniciales = espliteados_direcciones_bases_datos_y_fila_inicial[2].Split(G_separador_para_funciones_espesificas_[1][0]);
                if (i > 0)
                {
                    bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(espliteados_direcciones_bases_datos_y_fila_inicial[0], espliteados_direcciones_bases_datos_y_fila_inicial[1], filas_iniciales);
                }


            }

            chatbot_clase chatbot = new chatbot_clase();

            //estos estaran siempre al final del arreglo y para saber la posicion al el ultimo es el .Length-1 y si quieres el penultimo es .Length-2 y hasi susesivamente
            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(chatbot.G_dir_para_registros_y_configuraciones[2, 0], "id_usuario|venta");
            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(chatbot.G_dir_para_registros_y_configuraciones[1, 0], "folio_venta|añomesdiahoraminutosegundo|total|operacion|producto1¬precio1°pedido2¬precio2|vendedor|num_celular_vendedor|repartidor|datos_comprador°datos_comprador|datos_extra1°dato_extra2");

        }
    }
}
