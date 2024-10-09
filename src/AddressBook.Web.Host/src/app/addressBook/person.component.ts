import { Component, Injector, ChangeDetectionStrategy } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PersonDto, PersonServiceProxy } from '../../shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { PersonAddressPopup } from './Popup/personAddressPopup.component';

@Component({
  templateUrl: './person.component.html',
  animations: [appModuleAnimation()],
  changeDetection: ChangeDetectionStrategy.Default
})
export class PersonComponent extends AppComponentBase {

    personList: PersonDto[] = [];

    constructor(injector: Injector, private _personService: PersonServiceProxy, private _modalService: BsModalService) {
        super(injector);
    }

    ngOnInit() {
        this.getPersonList();
    }

    getPersonList() {
        this._personService.getPersonList().subscribe(result => {
            this.personList = result;
        })
    }

    getPersonAddressPopup(person) {
        let personAddressPopup: BsModalRef;

        personAddressPopup = this._modalService.show(
            PersonAddressPopup,
            {
                class: 'modal-lg',
                initialState: {
                    person: person
                }
            }
        );

        personAddressPopup.content.onSave.subscribe(() => {
            this.getPersonList();
        });
    }

}
