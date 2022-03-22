import { Component, Injector, OnInit, Renderer2 } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { NGOServiceProxy, NGODto, NGODtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { finalize } from 'rxjs/operators';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';

@Component({
  animations: [appModuleAnimation()],
  templateUrl: './charities.component.html', 
})
export class CharitiesComponent extends PagedListingComponentBase<NGODto>  {
  protected delete(entity: NGODto): void {
    throw new Error('Method not implemented.');
  }

  items: NGODto[] = [];
  keyword = '';
  loading:boolean;

  constructor(
    injector: Injector,
    private renderer: Renderer2,
    private _ngoService: NGOServiceProxy
    
  ) {
    super(injector);
  }

  list(
    request: PagedRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    

    this._ngoService
      .getAll(
        'id',
        
        request.skipCount,
        request.maxResultCount
      )
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: NGODtoPagedResultDto) => {
        this.items = result.items;
        this.showPaging(result, pageNumber);

       
      });
  }

}
