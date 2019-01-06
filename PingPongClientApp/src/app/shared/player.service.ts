import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import 'rxjs/add/operator/map';
import { Player } from './player.model';
import { Observable } from 'rxjs';

@Injectable()
export class PlayerService {
  readonly rootUrl = 'http://localhost:61392/api/player';


  constructor(private http: HttpClient) { }

  getPlayers() {
   return this.http.get(this.rootUrl + '/GetPlayers');
 }
 getSkillLevels() {
  return this.http.get(this.rootUrl + '/GetSkillLevelList');
}
 getPlayerById(Id : number) {
  return this.http.get(this.rootUrl + '/GetPlayer/'+ Id);
}
deletePlayer(Id : number) {
  return this.http.delete(this.rootUrl + '/DeletePlayer/'+Id);
}
  addPlayer(player: Player): Observable<Player> {
     const body: Player = {
      PlayerId: player.PlayerId,
      FirstName: player.FirstName,
      LastName: player.LastName,
      EmailAddress: player.EmailAddress,
      Age: player.Age,
      SkillLevelId: player.SkillLevelId,
      SkillLevelName : player.SkillLevelName
     }

    return this.http.post<Player>(this.rootUrl + '/AddOrUpdatePlayer',body);
  }
}
