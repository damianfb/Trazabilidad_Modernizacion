﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpHeaders, HttpRequest, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Constantes } from '../shared/Constantes';
import { map, catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';
import { DetallePlasticoModel } from '../model/detallePlasticoModel';
import { ComboModel } from '../model/ComboModel';
import { Conversion } from '../model/Conversion';
import { Estado } from '../model/Estado';
import { PaginadorModel } from '../model/PaginadorModel';
const _httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};
@Injectable()
export class ConsultasPlasticosServices {
    constructor(private _http: HttpClient) {
    }
    GetListaPlastico(PaginaActual: number): Observable<HttpResponse<DetallePlasticoModel[]>> {
        let consulta = Constantes.URL_OBTENER_SOLICITUDES_PLASTICOS;
        return this._http.get<DetallePlasticoModel[]>(consulta, { observe: 'response' })
            .pipe(
                catchError((error: HttpErrorResponse) => {
                    console.log(error.message);
                    return throwError(error.message);
                }))
    };


    GetListaPlasticos(PaginaActual: number): Observable<any> {
     
        return this._http.post<any>(Constantes.URL_OBTENER_SOLICITUDES_PLASTICOS, JSON.stringify(PaginaActual), _httpOptions)
            .pipe(
                map(
                    (response: DetallePlasticoModel[]) => response
                )
            );
    };


    GetListaFiltrosPlasticos(PlasticoFiltros: DetallePlasticoModel): Observable<any> {
        var respuesta = new  Array<DetallePlasticoModel>() ;
        return this._http.post<any>(Constantes.URL_OBTENER_FILTROS_PLASTICOS, JSON.stringify(PlasticoFiltros), _httpOptions)
            .pipe(
            map(
                (response: DetallePlasticoModel[]) => response
            )
        );
    };


   

    EnviarParametroDeFiltroRecibirParametrosDeNegociosModelListFiltrada(PaginaActual: number): Observable<DetallePlasticoModel[]> {
        return this._http.post<any>(Constantes.URL_OBTENER_FILTROS_PLASTICOS, JSON.stringify(PaginaActual), _httpOptions);
    }
    GetListaComboMarcas(): Observable<HttpResponse<Conversion[]>> {
        let consulta = Constantes.URL_OBTENER_COMBOS_PLASTICOS_MARCA;
        return this._http.get<Conversion[]>(consulta, { observe: 'response' })
            .pipe(
                catchError((error: HttpErrorResponse) => {
                    console.log(error.message);
                    return throwError(error.message);
                })) 
    };
    GetListaComboProductos(): Observable<HttpResponse<Conversion[]>> {
        let consulta = Constantes.URL_OBTENER_COMBOS_PLASTICOS_PRODUCTO;
        return this._http.get<Conversion[]>(consulta, { observe: 'response' })
            .pipe(
                catchError((error: HttpErrorResponse) => {
                    console.log(error.message);
                    return throwError(error.message);
                }))
    };
    GetListaCombosEstados(): Observable<HttpResponse<Estado[]>> {
        let consulta = Constantes.URL_OBTENER_COMBOS_PLASTICOS_ESTADOS;
        return this._http.get<Estado[]>(consulta, { observe: 'response' })
            .pipe(
                catchError((error: HttpErrorResponse) => {
                    console.log(error.message);
                    return throwError(error.message);
                }))
    };
}