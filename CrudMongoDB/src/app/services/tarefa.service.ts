import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Tarefa } from '../models/Tarefa';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TarefaService {
  constructor(private http: HttpClient) { }

  public getTarefas(): Observable<Tarefa> {
    return this.http.get<Tarefa>('/Tarefa/tarefas');
  }

  public getTarefa(id: string): Observable<Tarefa> {
    return this.http.get<Tarefa>('/Tarefa/tarefas/' + id);
  }

  public postTarefa(tarefa: Tarefa): Observable<any> {
    return this.http.post<Tarefa>('/Tarefa/tarefas/', tarefa);
  }

  public putTarefa(id: string, tarefa: Tarefa): Observable<any> {
    return this.http.put<Tarefa>('/Tarefa/tarefas/' + id, tarefa);
  }

  public deleteTarefa(id: string): Observable<any> {
    return this.http.delete<Tarefa>('/Tarefa/tarefas' + id);
  }
}
