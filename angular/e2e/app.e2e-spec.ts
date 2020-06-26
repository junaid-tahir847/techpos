import { TechPOSTemplatePage } from './app.po';

describe('TechPOS App', function() {
  let page: TechPOSTemplatePage;

  beforeEach(() => {
    page = new TechPOSTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
