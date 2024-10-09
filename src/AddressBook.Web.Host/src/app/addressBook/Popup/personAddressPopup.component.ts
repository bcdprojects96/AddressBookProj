import { Component, EventEmitter, Injector, OnInit, Output } from "@angular/core";
import { FormControl } from "@angular/forms";
import { ActivatedRoute, Router } from "@angular/router";

import { BsModalRef } from "ngx-bootstrap/modal";
import { Observable } from "rxjs";
import { debounceTime, distinctUntilChanged, filter, finalize, map, startWith, switchMap, tap } from "rxjs/operators";
import { AppComponentBase } from "../../../shared/app-component-base";
import { PersonDto} from "../../../shared/service-proxies/service-proxies";
import * as moment from "moment";

@Component({
    templateUrl: 'personAddressPopup.component.html'
})
export class PersonAddressPopup extends AppComponentBase implements OnInit {

    @Output() onSave = new EventEmitter<any>();
    person: any;

    constructor(injector: Injector,
        private route: ActivatedRoute,
        public bsModalRef: BsModalRef,
        private router: Router) {
        super(injector);
    }

    ngOnInit() {
        this.getLists();
    }

    getLists() {
       
    }


    save() {
       
    }
}