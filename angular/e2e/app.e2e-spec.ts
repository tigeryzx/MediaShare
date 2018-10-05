import { MediaShareTemplatePage } from './app.po';

describe('MediaShare App', function() {
  let page: MediaShareTemplatePage;

  beforeEach(() => {
    page = new MediaShareTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
