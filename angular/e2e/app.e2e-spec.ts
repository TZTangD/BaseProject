import { saasTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: saasTemplatePage;

  beforeEach(() => {
    page = new saasTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
