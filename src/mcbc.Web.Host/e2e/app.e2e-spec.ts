import { mcbcTemplatePage } from './app.po';

describe('mcbc App', function() {
  let page: mcbcTemplatePage;

  beforeEach(() => {
    page = new mcbcTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
