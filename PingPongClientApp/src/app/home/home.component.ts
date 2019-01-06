import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { PlayerService } from '../shared/player.service';
import { Player, SkillLevel } from '../shared/player.model';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
declare var $: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  players: Array<Player>;
  skillLevels : Array<SkillLevel>;
 loading: boolean = false;
 showgrid: boolean = false;
 showform: boolean = false;
 player : Player;
 playerIdToBeDeleted : number = 0;
 emailPattern = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  constructor(private router: Router, private http: HttpClient, private playerService : PlayerService,  private toastr: ToastrService) { }

  ngOnInit() {
    this.showgrid = true;
    this.getSkillLevels();
    this.getPlayers();
    $(document).ready(function(){
      $('.modal').modal();
    });
   
  }

  getSkillLevels(){
    this.loading = true;
    this.playerService.getSkillLevels().subscribe((data : any) => {
      this.skillLevels = data.Data;
      this.loading = false;
    },
    err => {
      this.loading = false;
      console.log(err);
      console.log("Error occured");
    });

  }

  getPlayers() {
    this.loading = true;
    this.playerService.getPlayers().subscribe((data : any) => {
      this.players = data.Data;
      this.loading = false;
    },
    err => {
      this.loading = false;
      console.log(err);
      console.log("Error occured");
    });
  }

  addPlayer(){
    this.resetForm();
    this.showform = true;
    this.showgrid = false;
    
     }

  editPlayer(p){
    this.resetForm();
    this.showform = true;
    this.showgrid = false;
    this.player = {
      PlayerId : p.PlayerId,
      SkillLevelId: p.SkillLevelId,
      SkillLevelName : p.SkillLevelName,
      Age: p.Age,
      EmailAddress: p.EmailAddress,
      FirstName: p.FirstName,
      LastName: p.LastName,
    }
  }

  cancel(){
    this.showform = false;
    this.showgrid = true;
  }

  deleteConfirm(player : Player){
    this.playerIdToBeDeleted = player.PlayerId;
  }

  deletePlayer()
  {
    this.loading = true;
    this.playerService.deletePlayer(this.playerIdToBeDeleted).subscribe((data: any) => {
      this.loading = false;
      if (data.StatusCode == 0) {
        this.toastr.success('Player deleted successfully');
        this.getPlayers();
      }
      else
        this.toastr.error(data.Message);
    });

  }

  OnSubmit(form: NgForm) {
    this.playerService.addPlayer(this.player).subscribe((data: any) => {
        if (data.StatusCode == 0) {
          this.toastr.success('Player ' + (this.player.PlayerId > 0 ? 'updated' : 'added') + ' successfully');
          this.resetForm(form);
          this.getPlayers();
          this.showgrid = true;
          this.showform = false;
        }
        else
          this.toastr.error(data.Message);
      });
  }

  change(value: any) {
    console.log('Selected value is: ', value);
  }


  resetForm(form?: NgForm) {
    if (form != null)
      form.reset();
    this.player = {
      PlayerId : 0,
      SkillLevelId: 1,
      SkillLevelName : '',
      Age: null,
      EmailAddress: '',
      FirstName: '',
      LastName: ''
    }
  }
}
